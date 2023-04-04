
using Syspro.Model;
using SYSPROWCFServicesClientLibrary40;
using System.IO;
using System.Xml;
using System;
using System.Xml.Serialization;
using System.Configuration;
using Newtonsoft.Json;

namespace Syspro
{
    public class ApiService
    {
        //public ApiService(IConfiguration configuration) 
        //{ 
        //    _configuration = configuration;
        //}

        public string Logon()
        {
            var sysproApiConfig = (SysproApiConfig)ConfigurationManager.GetSection(nameof(SysproApiConfig));
            var operatorName = sysproApiConfig.OperatorName;
            var password = sysproApiConfig.Password;
            var companyId = sysproApiConfig.CompanyId;
            var companyPassword = sysproApiConfig.CompanyPassword;

            var client = GetClient();
            var guid = client.Logon(operatorName, password, companyId, companyPassword);
            return guid;
        }

        public void Logoff(string guid)
        {
            var client = GetClient();
            client.Logoff(guid);
        }

        public SYSPROWCFServicesPrimitiveClient GetClient()
        {
            var sysproApiConfig = (SysproApiConfig)ConfigurationManager.GetSection(nameof(SysproApiConfig));
            var baseAddress = sysproApiConfig.BaseAddress;
            SYSPROWCFServicesPrimitiveClient client = new SYSPROWCFServicesPrimitiveClient(baseAddress, SYSPROWCFBinding.NetTcp);
            return client;
        }

        public void AddCustomer(SetupArCustomerRequest setupArCustomerRequest) 
        {
            var guid = Logon();
            var client = GetClient();
            var customerBOxml = ConvertObjectToXml(setupArCustomerRequest);
            var response = client.SetupAdd(guid, "ARSSCS", "", customerBOxml);
            var setupArCustomerResponse = ConvertXmlToObject<SetupArCustomerResponse>(response);
            Logoff(guid);
        }

        public void UpdateCustomer(SetupArCustomerRequest setupArCustomerRequest)
        {
            var guid = Logon();
            var client = GetClient();
            var customerBOxml = ConvertObjectToXml(setupArCustomerRequest);
            var response = client.SetupUpdate(guid, "ARSSCS", "", customerBOxml);
            var setupArCustomerResponse = ConvertXmlToObject<SetupArCustomerResponse>(response);
            Logoff(guid);
        }
        public string ConvertObjectToXml<T>(T data)
        {
            var stringwriter = new StringWriter();
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stringwriter, data);
            return stringwriter.ToString();
        }

        public T ConvertXmlToObject<T>(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml)) return default(T);

            using (StringReader stringReader = new StringReader(xml))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
        }
    }
}
