using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Models
{
    public class Chapter
    {
        [JsonProperty("length_ms")]
        public int LengthMs;

        [JsonProperty("start_offset_ms")]
        public int StartOffsetMs;

        [JsonProperty("start_offset_sec")]
        public int StartOffsetSec;

        [JsonProperty("title")]
        public string Title;
    }
}
