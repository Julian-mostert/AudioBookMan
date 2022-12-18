using Newtonsoft.Json;

namespace AudioBookMan.Core.Audnexus.DTO.Models;

public class Link
{
    [JsonProperty("link")]
    public string LinkUrl;

    [JsonProperty("type")]
    public string Type;
}


