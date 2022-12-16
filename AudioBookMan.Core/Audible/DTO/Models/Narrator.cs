using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Models
{
    public class Narrator
    {
        [JsonProperty("name")]
        public string Name;
    }
}
