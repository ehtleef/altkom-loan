using System;

namespace Loan.Service.Contracts
{
    public class LoanRequestDto
    {
        public string CustomerName { get; set; }

        public DateTime CustomerBirthday { get; set; }

        public string CustomerTaxId { get; set; }

        public decimal CustomerMonthlyIncome { get; set; }

        public decimal LoanAmount { get; set; }

        public int NumberOfInstallments { get; set; }

        public DateTime FirstInstallmentDate { get; set; }
    }
}
