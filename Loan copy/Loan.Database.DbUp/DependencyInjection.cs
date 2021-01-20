using Loan.Database;
using Microsoft.Extensions.DependencyInjection;

namespace LoanDatabase.DbUp
{
    public static class DependencyInjection
    {
        public static void AddLoanDatabaseDbUp(this IServiceCollection services)
        {
            services.AddScoped<IMigrator, DbUpSqlServerMigrator>();
        }
    }
}