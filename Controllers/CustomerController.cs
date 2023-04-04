using TFS.Syspro.Models;
using System.Text;
using System.Web.Http;
using TFS.Syspro.Customer;

namespace TFS.Syspro.WebApi.Controllers
{
    [Route("api/customers")]

    public class CustomerController : ApiController
    {
        private readonly WCFService _apiService;
        public CustomerController()
        {
            _apiService = new WCFService();
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

        [HttpPut]
        public string Update([FromBody] SetupArCustomerRequest req)

        {
            _apiService.UpdateCustomer(req);
            return "updated";
        }

        /*public string GetEncoding()
        {
            // get the correct encodings 
            var srcEncoding = Encoding.GetEncoding(16); // utf-16
            var destEncoding = Encoding.GetEncoding(1252); // windows-1252

            // convert the source bytes to the destination bytes
            var destBytes = Encoding.Convert(srcEncoding, destEncoding, srcEncoding.GetBytes(srcString));

            // process the byte[]
            File.WriteAllBytes("myFile", destBytes); // write it to a file OR ...
            var destString = destEncoding.GetString(destBytes); // ... get the string
        }*/
    }
}