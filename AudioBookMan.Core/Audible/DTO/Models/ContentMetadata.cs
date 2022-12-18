using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Models;

public class ContentMetadata
{
    [JsonProperty("chapter_info")]
    public ChapterInfo ChapterInfo;

    [JsonProperty("content_reference")]
    public ContentReference ContentReference;
}


