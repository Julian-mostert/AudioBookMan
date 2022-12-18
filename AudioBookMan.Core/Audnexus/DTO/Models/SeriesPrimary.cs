using Newtonsoft.Json;

namespace AudioBookMan.Core.Audnexus.DTO.Models;

public class SeriesPrimary
{
    [JsonProperty("asin")]
    public string Asin;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("position")]
    public string Position;
}


