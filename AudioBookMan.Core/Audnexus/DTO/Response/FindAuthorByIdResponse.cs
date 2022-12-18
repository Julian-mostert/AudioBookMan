using AudioBookMan.Core.Audnexus.DTO.Models;
using Newtonsoft.Json;

namespace AudioBookMan.Core.Audnexus.DTO.Response;

public class FindAuthorByIdResponse
{
    [JsonProperty("aliases")]
    public List<string> Aliases;

    [JsonProperty("asin")]
    public string Asin;

    [JsonProperty("birthDate")]
    public string BirthDate;

    [JsonProperty("books")]
    public List<Book> Books;

    [JsonProperty("description")]
    public string Description;

    [JsonProperty("genres")]
    public List<Genre> Genres;

    [JsonProperty("image")]
    public string Image;

    [JsonProperty("links")]
    public List<Link> Links;

    [JsonProperty("location")]
    public string Location;

    [JsonProperty("name")]
    public string Name;

    [JsonProperty("region")]
    public string Region;

    [JsonProperty("series")]
    public string Series;
}


