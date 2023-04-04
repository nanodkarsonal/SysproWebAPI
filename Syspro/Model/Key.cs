

using Newtonsoft.Json;

namespace Syspro.Model
{
    public partial class Key
    {
        [JsonProperty("customer")]
        public long Customer { get; set; }

    }
}
