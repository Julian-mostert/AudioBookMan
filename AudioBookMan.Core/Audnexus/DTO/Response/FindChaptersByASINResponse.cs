using AudioBookMan.Core.Audible.DTO.Models;
using Newtonsoft.Json;

namespace AudioBookMan.Core.Audnexus.DTO.Response;

public class FindChaptersByAsinResponse
{
    [JsonProperty("asin")]
    public string Asin;

    [JsonProperty("brandIntroDurationMs")]
    public int BrandIntroDurationMs;

    [JsonProperty("brandOutroDurationMs")]
    public int BrandOutroDurationMs;

    [JsonProperty("chapters")]
    public List<Chapter> Chapters;

    [JsonProperty("isAccurate")]
    public bool IsAccurate;

    [JsonProperty("region")]
    public string Region;

    [JsonProperty("runtimeLengthMs")]
    public int RuntimeLengthMs;

    [JsonProperty("runtimeLengthSec")]
    public int RuntimeLengthSec;
}


