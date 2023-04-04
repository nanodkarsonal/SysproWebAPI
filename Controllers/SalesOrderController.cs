

using System.Web.Http;
using TFS.Syspro.Models;

namespace TFS.Syspro.WebApi.Controllers
{
    public class SalesOrderController : ApiController
    {
        public SalesOrderController()
        {
            
        }

        [HttpPost]
        public string CreateSalesOrder()
        {
            return "created";
        }
    }
}