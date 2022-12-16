using AudioBookMan.Core.Audible.DTO.Models;
using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Response
{
    public class ContentMetaDataResponse
    {
        [JsonProperty("content_metadata")]
        public ContentMetadata ContentMetadata;

        [JsonProperty("response_groups")]
        public List<string> ResponseGroups;
    }
}
