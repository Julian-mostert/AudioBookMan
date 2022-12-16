using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Models
{
    public class ChapterInfo
    {
        [JsonProperty("brandIntroDurationMs")]
        public int BrandIntroDurationMs;

        [JsonProperty("brandOutroDurationMs")]
        public int BrandOutroDurationMs;

        [JsonProperty("chapters")]
        public List<Chapter> Chapters;

        [JsonProperty("is_accurate")]
        public bool IsAccurate;

        [JsonProperty("runtime_length_ms")]
        public int RuntimeLengthMs;

        [JsonProperty("runtime_length_sec")]
        public int RuntimeLengthSec;
    }
}
