using Newtonsoft.Json;

namespace AudioBookMan.Core.Audnexus.DTO.Models;

public class Genre
{
    [JsonProperty("asin")]
    public string Asin;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("type")]
    public string Type;
}


