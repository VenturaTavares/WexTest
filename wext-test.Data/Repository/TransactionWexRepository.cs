using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wex_test.Domain;

namespace wext_test.Data.Repository
{
    public class TransactionWexRepository : ITransactionWexRepository
    {


        public TransactionWexRepository(WexTestContext context)
        {
            this._context = context;
        }

        private readonly WexTestContext _context;


        public async Task Create(TransactionWex transaction)
        {
            this._context.Transactions.Add(transaction);
            await this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TransactionWex>> GetTransactions()
        {
            return await _context.Transactions.AsNoTracking().ToListAsync();
        }
    }
}
