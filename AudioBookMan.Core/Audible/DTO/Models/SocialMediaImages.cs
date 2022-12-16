using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Models
{
    public class SocialMediaImages
    {
        [JsonProperty("facebook")]
        public string Facebook;

        [JsonProperty("twitter")]
        public string Twitter;
    }
}
