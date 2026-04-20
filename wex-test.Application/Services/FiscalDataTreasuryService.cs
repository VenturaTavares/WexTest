using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using wex_test.Application.ViewModels;
using static wex_test.Application.ViewModels.FiscalDataTreasureResponseViewModel;

namespace wex_test.Application.Services
{
    public class FiscalDataTreasuryService : IFiscalDataTreasuryService
    {
        private readonly HttpClient _httpClient;
        public FiscalDataTreasuryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<TreasuryRatesResponseDto> GetDataTreasures(DateTime startDate)
        {
            var url =
               "https://api.fiscaldata.treasury.gov/services/api/fiscal_service/v1/accounting/od/rates_of_exchange" +
               "?fields=country_currency_desc,exchange_rate,record_date" +
               $"&filter=country_currency_desc:in:(Euro Zone-Euro),record_date:gte:{startDate:yyyy-MM-dd}";

            using var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var result = JsonSerializer.Deserialize<TreasuryRatesResponseDto>(json, options);

            if (result == null || result.Data == null)
            {
                return null;

            }
            return result;
        }
    }
}
