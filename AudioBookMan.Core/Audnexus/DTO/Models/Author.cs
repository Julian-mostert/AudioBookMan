using Newtonsoft.Json;

namespace AudioBookMan.Core.Audnexus.DTO.Models;

public class Author
{
    [JsonProperty("asin")]
    public string Asin;

    [JsonProperty("name")]
    public string Name;
}


