using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Models;

public class Product
{
    [JsonProperty("asin")]
    public string Asin;

    [JsonProperty("audible_editors_summary")]
    public string AudibleEditorsSummary;

    [JsonProperty("authors")]
    public List<Author> Authors;

    [JsonProperty("available_codecs")]
    public List<AvailableCodec> AvailableCodecs;

    [JsonProperty("content_delivery_type")]
    public string ContentDeliveryType;

    [JsonProperty("content_type")]
    public string ContentType;

    [JsonProperty("format_type")]
    public string FormatType;

    [JsonProperty("has_children")]
    public bool HasChildren;

    [JsonProperty("is_adult_product")]
    public bool IsAdultProduct;

    [JsonProperty("is_listenable")]
    public bool IsListenable;

    [JsonProperty("is_purchasability_suppressed")]
    public bool IsPurchasabilitySuppressed;

    [JsonProperty("issue_date")]
    public string IssueDate;

    [JsonProperty("language")]
    public string Language;

    [JsonProperty("merchandising_summary")]
    public string MerchandisingSummary;

    [JsonProperty("narrators")]
    public List<Narrator> Narrators;

    [JsonProperty("product_images")]
    public ProductImages ProductImages;

    [JsonProperty("publication_name")]
    public string PublicationName;

    [JsonProperty("publisher_name")]
    public string PublisherName;

    [JsonProperty("publisher_summary")]
    public string PublisherSummary;

    [JsonProperty("release_date")]
    public string ReleaseDate;

    [JsonProperty("runtime_length_min")]
    public int RuntimeLengthMin;

    [JsonProperty("social_media_images")]
    public SocialMediaImages SocialMediaImages;

    [JsonProperty("subtitle")]
    public string Subtitle;

    [JsonProperty("thesaurus_subject_keywords")]
    public List<string> ThesaurusSubjectKeywords;

    [JsonProperty("title")]
    public string Title;
}


