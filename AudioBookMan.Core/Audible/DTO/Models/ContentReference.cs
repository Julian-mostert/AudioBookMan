using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Models
{
    public class ContentReference
    {
        [JsonProperty("acr")]
        public string Acr;

        [JsonProperty("asin")]
        public string Asin;

        [JsonProperty("content_format")]
        public string ContentFormat;

        [JsonProperty("content_size_in_bytes")]
        public int ContentSizeInBytes;

        [JsonProperty("file_version")]
        public string FileVersion;

        [JsonProperty("marketplace")]
        public string Marketplace;

        [JsonProperty("sku")]
        public string Sku;

        [JsonProperty("tempo")]
        public string Tempo;

        [JsonProperty("version")]
        public string Version;
    }
}
