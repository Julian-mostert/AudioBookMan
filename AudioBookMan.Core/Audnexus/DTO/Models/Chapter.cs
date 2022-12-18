using Newtonsoft.Json;

namespace AudioBookMan.Core.Audnexus.DTO.Models;

public class Chapter
{
    [JsonProperty("lengthMs")]
    public int LengthMs;

    [JsonProperty("startOffsetMs")]
    public int StartOffsetMs;

    [JsonProperty("startOffsetSec")]
    public int StartOffsetSec;

    [JsonProperty("title")]
    public string Title;
}



