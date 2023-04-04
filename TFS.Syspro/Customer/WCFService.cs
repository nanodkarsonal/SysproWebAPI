using TFS.Syspro.Models;


namespace TFS.Syspro.Customer
{
    public class WCFService
    {
        private readonly Common.WCFService _commonWCFService;
        public WCFService() 
        {
            _commonWCFService = new Common.WCFService();
        }
        public void AddCustomer(SetupArCustomerRequest setupArCustomerRequest)
        {
            var guid = _commonWCFService.Logon();
            var client = _commonWCFService.GetClient();
            var customerBOxml = _commonWCFService.ConvertObjectToXml(setupArCustomerRequest);
            var response = client.SetupAdd(guid, "ARSSCS", "", customerBOxml);
            var setupArCustomerResponse = _commonWCFService.ConvertXmlToObject<SetupArCustomerResponse>(response);
            _commonWCFService.Logoff(guid);
        }

        public void UpdateCustomer(SetupArCustomerRequest setupArCustomerRequest)
        {
            var guid = _commonWCFService.Logon();
            var client = _commonWCFService.GetClient();
            var customerBOxml = _commonWCFService.ConvertObjectToXml(setupArCustomerRequest);
            var response = client.SetupUpdate(guid, "ARSSCS", "", customerBOxml);
            var setupArCustomerResponse = _commonWCFService.ConvertXmlToObject<SetupArCustomerResponse>(response);
            _commonWCFService.Logoff(guid);
        }
    }
}
