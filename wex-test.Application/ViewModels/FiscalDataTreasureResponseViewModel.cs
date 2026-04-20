using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace wex_test.Application.ViewModels
{
    public  class FiscalDataTreasureResponseViewModel
    {
        [JsonPropertyName("country_currency_desc")]
        public string CountryCurrencyDescription { get; set; } = string.Empty;

        [JsonPropertyName("exchange_rate")]
        public decimal ExchangeRate { get; set; }

        [JsonPropertyName("record_date")]
        public DateTime RecordDate { get; set; }


     

    }
}
