using Newtonsoft.Json;

namespace AudioBookMan.Core.Audnexus.DTO.Models;

public class Book
{
    [JsonProperty("asin")]
    public string Asin;

    [JsonProperty("authors")]
    public List<Author> Authors;

    [JsonProperty("description")]
    public string Description;

    [JsonProperty("formatType")]
    public string FormatType;

    [JsonProperty("genres")]
    public List<Genre> Genres;

    [JsonProperty("image")]
    public string Image;

    [JsonProperty("language")]
    public string Language;

    [JsonProperty("narrators")]
    public List<Narrator> Narrators;

    [JsonProperty("publisherName")]
    public string PublisherName;

    [JsonProperty("rating")]
    public int Rating;

    [JsonProperty("region")]
    public string Region;

    [JsonProperty("releaseDate")]
    public string ReleaseDate;

    [JsonProperty("runtimeLengthMin")]
    public int RuntimeLengthMin;

    [JsonProperty("seriesPrimary")]
    public SeriesPrimary SeriesPrimary;

    [JsonProperty("seriesSecondary")]
    public SeriesSecondary SeriesSecondary;

    [JsonProperty("subtitle")]
    public string Subtitle;

    [JsonProperty("summary")]
    public string Summary;

    [JsonProperty("title")]
    public string Title;
}


