using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wex_test.Domain
{
    public interface ITransactionWexRepository 
    {
        Task<IEnumerable<TransactionWex>> GetTransactions();

        Task Create(TransactionWex transaction);
    }
}
