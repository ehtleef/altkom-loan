namespace Loan.Service.Contracts
{
    public class LoanRequestRegistrationResultDto
    {
        public string LoanRequestNumber { get; set; }

        public LoanRequestEvaluationResult EvaluationResult { get; set; }
    }
}
