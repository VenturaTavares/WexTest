using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace wex_test.Application.ViewModels
{
    public class TreasuryRatesResponseDto
    {
        [JsonPropertyName("data")]
        public List<TreasuryRateDto> Data { get; set; } = new();

        [JsonPropertyName("meta")]
        public TreasuryMetaDto Meta { get; set; } = new();

        [JsonPropertyName("links")]
        public TreasuryLinksDto Links { get; set; } = new();
    }

    public class TreasuryRateDto
    {
        [JsonPropertyName("country_currency_desc")]
        public string CountryCurrencyDescription { get; set; } = string.Empty;

        [JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }

        [JsonPropertyName("record_date")]
        public DateTime RecordDate { get; set; }
    }

    public class TreasuryMetaDto
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("labels")]
        public TreasuryLabelsDto Labels { get; set; } = new();

        [JsonPropertyName("dataTypes")]
        public TreasuryDataTypesDto DataTypes { get; set; } = new();

        [JsonPropertyName("dataFormats")]
        public TreasuryDataFormatsDto DataFormats { get; set; } = new();

        [JsonPropertyName("total-count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("total-pages")]
        public int TotalPages { get; set; }
    }

    public class TreasuryLabelsDto
    {
        [JsonPropertyName("country_currency_desc")]
        public string CountryCurrencyDescription { get; set; } = string.Empty;

        [JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; } = string.Empty;

        [JsonPropertyName("record_date")]
        public string RecordDate { get; set; } = string.Empty;
    }

    public class TreasuryDataTypesDto
    {
        [JsonPropertyName("country_currency_desc")]
        public string CountryCurrencyDescription { get; set; } = string.Empty;

        [JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; } = string.Empty;

        [JsonPropertyName("record_date")]
        public string RecordDate { get; set; } = string.Empty;
    }

    public class TreasuryDataFormatsDto
    {
        [JsonPropertyName("country_currency_desc")]
        public string CountryCurrencyDescription { get; set; } = string.Empty;

        [JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; } = string.Empty;

        [JsonPropertyName("record_date")]
        public string RecordDate { get; set; } = string.Empty;
    }

    public class TreasuryLinksDto
    {
        [JsonPropertyName("self")]
        public string Self { get; set; } = string.Empty;

        [JsonPropertyName("first")]
        public string First { get; set; } = string.Empty;

        [JsonPropertyName("prev")]
        public string? Prev { get; set; }

        [JsonPropertyName("next")]
        public string? Next { get; set; }

        [JsonPropertyName("last")]
        public string Last { get; set; } = string.Empty;
    }
}
