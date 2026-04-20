using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace wex_test.Application.ViewModels
{
    public class TransactionViewModel
    {
        public int TransactionID { get; set; }

        [StringLength(60, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public Decimal PurchaseAmount { get; set; }
        public Decimal PurchaseAmountConverted { get; set; }
        public Decimal ExchangeRate { get; set; }

        public string CountryCurrencyDescription { get; set; }


    }
}
