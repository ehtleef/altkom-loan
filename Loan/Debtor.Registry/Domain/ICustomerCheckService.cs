using Debtor.Registry.Contracts;

namespace Debtor.Registry.Domain
{
    public interface ICustomerCheckService
    {
        CustomerCheckResultDto CheckCustomer(string customerTaxId);
    }
}
