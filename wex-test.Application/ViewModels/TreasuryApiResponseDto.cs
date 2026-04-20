using System.Text.Json.Serialization;
using wex_test.Application.ViewModels;

namespace wex_test.Application.ViewModels
{
    public class TreasuryApiResponseDto
    {
        [JsonPropertyName("data")]
        public List<FiscalDataTreasureResponseViewModel> Data { get; set; } = new();

       
    }
}