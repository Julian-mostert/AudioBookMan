using AudioBookMan.Core.Audible.DTO.Models;
using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Response
{
    public class CatalogResponse
    {
        [JsonProperty("product")]
        public Product Product;

        [JsonProperty("response_groups")]
        public List<string> ResponseGroups;
    }
}
