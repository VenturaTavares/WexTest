using wex_test.Application.Services;
using wex_test.Domain;
using wext_test.Data;
using wext_test.Data.Repository;

namespace wex_test.Setup
{
    public static class DependecyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IFiscalDataTreasuryService, FiscalDataTreasuryService>();
            services.AddScoped<ITransactionWexRepository, TransactionWexRepository>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<ITransactionWexRepository, TransactionWexRepository>();
            services.AddScoped<WexTestContext>();
            services.AddScoped<HttpClient>();
        }

    }
}
