using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Models;

public class AvailableCodec
{
    [JsonProperty("enhanced_codec")]
    public string EnhancedCodec = string.Empty;

    [JsonProperty("format")]
    public string Format = string.Empty;

    [JsonProperty("is_kindle_enhanced")]
    public bool IsKindleEnhanced;

    [JsonProperty("name")]
    public string Name = string.Empty;
}


