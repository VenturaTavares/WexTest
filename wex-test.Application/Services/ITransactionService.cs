using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wex_test.Application.ViewModels;


namespace wex_test.Application.Services
{
    public interface ITransactionService
    {
        Task CreateTransaction(TransactionViewModel transaction);

        Task<IEnumerable<TransactionViewModel>> GetTransactions();
    }
}
