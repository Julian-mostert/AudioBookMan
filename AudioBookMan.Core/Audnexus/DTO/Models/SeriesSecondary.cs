using Newtonsoft.Json;

namespace AudioBookMan.Core.Audnexus.DTO.Models;

public class SeriesSecondary
{
    [JsonProperty("asin")]
    public string Asin;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("position")]
    public string Position;
}


