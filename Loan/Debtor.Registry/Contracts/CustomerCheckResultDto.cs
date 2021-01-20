using System;

namespace Debtor.Registry.Contracts
{
    public class CustomerCheckResultDto
    {
        public string CustomerTaxId { get; set; }
        public bool IsRegisteredDebtor { get; set; }

        public static CustomerCheckResultDto DebtorCustomer(string customerTaxId)
        {
            return new CustomerCheckResultDto(customerTaxId, true);
        }

        public static CustomerCheckResultDto NotDebtorCustomer(string customerTaxId)
        {
            return new CustomerCheckResultDto(customerTaxId, false);
        }

        public CustomerCheckResultDto(string customerTaxId, bool isRegisteredDebtor)
        {
            CustomerTaxId = customerTaxId;
            IsRegisteredDebtor = isRegisteredDebtor;
        }
    }
}
