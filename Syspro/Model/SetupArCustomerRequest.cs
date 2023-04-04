

using Newtonsoft.Json;
using System;

namespace Syspro.Model
{
    public class SetupArCustomerRequest
    {
        [JsonProperty("SetupArCustomer")]
        public SetupArCustomer SetupArCustomer { get; set; }
    }
    public partial class SetupArCustomer
    {
        [JsonProperty("Item")]
        public Item Item { get; set; }

        //[JsonProperty("_xmlns:xsd")]
        //public Uri XmlnsXsd { get; set; }

        [JsonProperty("_xsd:noNamespaceSchemaLocation")]
        public string XsdNoNamespaceSchemaLocation { get; set; }
    }


}
