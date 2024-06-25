using Newtonsoft.Json;
using System.Runtime;
using System.Threading.Tasks.Dataflow;

namespace DTO
{
    public class JsonPasuks
    {
        [JsonProperty("namePasuk")]
        public string NamePasuk { get; set; }

        [JsonProperty("pasuks")]
        public List<string> Pasuks { get; set; }

    }
}
