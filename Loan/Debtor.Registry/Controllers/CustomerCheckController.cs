using Debtor.Registry.Contracts;
using Debtor.Registry.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Debtor.Registry.Controllers
{
    [Route("api/customercheck")]
    [ApiController]
    public class CustomerCheckController : ControllerBase
    {
        private readonly ICustomerCheckService customerCheckService;

        public CustomerCheckController(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }


        [HttpGet("{customerTaxId}")]
        public CustomerCheckResultDto Check(string customerTaxId)
        {
            return customerCheckService.CheckCustomer(customerTaxId);
        }

    }
}
