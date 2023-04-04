
using Newtonsoft.Json;

namespace Syspro.Model
{
    internal class SetupArCustomerResponse
    {
        [JsonProperty("setuparcustomer")]
        public Setuparcustomer Setuparcustomer { get; set; }
    }

    public partial class Setuparcustomer
    {
        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("StatusOfItems")]
        public StatusOfItems StatusOfItems { get; set; }

        [JsonProperty("_Language")]
        public string Language { get; set; }

        [JsonProperty("_Language2")]
        public string Language2 { get; set; }

        [JsonProperty("_CssStyle")]
        public string CssStyle { get; set; }

        [JsonProperty("_DecFormat")]
        public long DecFormat { get; set; }

        [JsonProperty("_DateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("_Role")]
        public string Role { get; set; }

        [JsonProperty("_Version")]
        public string Version { get; set; }

        [JsonProperty("_OperatorPrimaryRole")]
        public string OperatorPrimaryRole { get; set; }
    }

    public partial class StatusOfItems
    {
        [JsonProperty("RecordsRead")]
        public long RecordsRead { get; set; }

        [JsonProperty("RecordsInvalid")]
        public long RecordsInvalid { get; set; }
    }

}
