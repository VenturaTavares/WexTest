using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wex_test.Application.ViewModels;
using static wex_test.Application.ViewModels.FiscalDataTreasureResponseViewModel;

namespace wex_test.Application.Services
{
    public interface IFiscalDataTreasuryService
    {
        Task<TreasuryRatesResponseDto> GetDataTreasures(DateTime startDate);
    }
}
