using System;

namespace Loan.Service.Contracts
{
    public class LoanRequestDataDto
    {
        public string LoanRequestNumber { get; set; }

        public string CustomerName { get; set; }

        public DateTime CustomerBirthday { get; set; }

        public string CustomerTaxId { get; set; }

        public decimal CustomerMonthlyIncome { get; set; }

        public decimal LoanAmount { get; set; }

        public int NumberOfInstallments { get; set; }

        public DateTime FirstInstallmentDate { get; set; }

        public LoanRequestEvaluationResult EvaluationResult { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
