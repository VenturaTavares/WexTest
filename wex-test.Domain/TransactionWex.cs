using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wex_test.Domain
{
    public class TransactionWex
    {
        public int TransactionID { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public Decimal PurchaseAmount { get; set; }
        public Decimal PurchaseAmountConverted { get; set; }
        public Decimal ExchangeRate { get; set; }

        public string CountryCurrencyDescription { get; set; }

        public void CalculateConversion(decimal ExchangeRate, string countryCurrencyDescription)
        {
            PurchaseAmountConverted = ExchangeRate * PurchaseAmount;
            this.ExchangeRate = ExchangeRate;
            this.CountryCurrencyDescription = countryCurrencyDescription;
        }
    }
}
