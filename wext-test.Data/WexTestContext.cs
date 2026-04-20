using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using wex_test.Domain;

namespace wext_test.Data
{
    public class WexTestContext : DbContext
    {
        public WexTestContext(DbContextOptions<WexTestContext> options)
            : base(options) { 
        
        }

        public DbSet<TransactionWex> Transactions { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WexTestContext).Assembly);
        }

    
    }
}
