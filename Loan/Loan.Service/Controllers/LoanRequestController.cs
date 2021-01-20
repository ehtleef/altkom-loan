using System;
using Loan.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Loan.Service.Controllers
{
    [Route("api/loans")]
    [ApiController]
    public class LoanRequestController : ControllerBase
    {
        [HttpPost]
        public LoanRequestRegistrationResultDto Register([FromBody] LoanRequestDto loanRequest)
        {
                Console.WriteLine("REGISTER");
            //TODO: implement
            return null;
        }

        [HttpGet("{loanNumber}")]
        public LoanRequestDataDto GetByNumber(string loanNumber)
        {
            Console.WriteLine("getby number");
            //TODO: implement
            return null;
        }
    }
}
