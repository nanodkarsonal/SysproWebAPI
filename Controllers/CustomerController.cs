using Syspro;
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
            _apiService.AddCustomer();
            return "added customer";
        }

        [HttpPost]
        public string CreateCustomer()
        {
            var customers = new Customers();
            return "created";
        }

        [HttpPut]
        public string Update(int id)

        {
            return "updated";
        }
    }
}