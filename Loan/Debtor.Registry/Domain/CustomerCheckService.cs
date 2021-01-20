using Debtor.Registry.Contracts;
using System.Collections.Generic;

namespace Debtor.Registry.Domain
{
    public class CustomerCheckService : ICustomerCheckService
    {
        private readonly List<string> blackList = new List<string>()
        {
            "35062600206",
            "40080200695",
            "01222815571",
            "51092513727"
        };

        public CustomerCheckResultDto CheckCustomer(string customerTaxId)
        {
            if (blackList.Contains(customerTaxId))
            {
                return CustomerCheckResultDto.DebtorCustomer(customerTaxId);
            }
            else
            {
                return CustomerCheckResultDto.NotDebtorCustomer(customerTaxId);
            }
        }
    }
}
