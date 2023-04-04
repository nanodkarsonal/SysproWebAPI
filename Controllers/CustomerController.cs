using Syspro;
using Syspro.Model;
using SysproWebApi.Models;
using System.Web.Http;


namespace SysproWebApi.Controllers
{
    [Route("api/customers")]

    public class CustomerController : ApiController
    {
        private readonly ApiService _apiService;
        public CustomerController()
        {
            _apiService = new ApiService();
        }

        [HttpGet]
        public string Get()
        {
            
            return "added customer";
        }

        [HttpPost]
        public string CreateCustomer([FromBody] SetupArCustomerRequest req)
        {
            _apiService.AddCustomer(req);
            return "created";
        }

        [HttpPost]
        public string UpdateCustomer([FromBody] SetupArCustomerRequest req)
        {
            _apiService.AddCustomer(req);
            return "created";
        }

        [HttpPut]
        public string Update(int id)

        {
            return "updated";
        }
    }
}