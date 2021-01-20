namespace Loan.Database
{
    public interface IMigrator
    {
        void Execute(string connectionString);
    }
}