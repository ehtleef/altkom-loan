using LoanDatabase.DbUp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Loan.Database.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddLoanDatabaseDbUp();
                    services.AddHostedService<MigratorRunner>();
                })
                .RunConsoleAsync();
        }
    }
}