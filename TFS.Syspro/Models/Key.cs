

using Newtonsoft.Json;

namespace TFS.Syspro.Models
{
    public partial class Key
    {
        [JsonProperty("customer")]
        public long Customer { get; set; }

    }
}
