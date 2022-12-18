using AudioBookMan.Core.Audible.DTO.Models;
using Newtonsoft.Json;

namespace AudioBookMan.Core.Audible.DTO.Response;

public class CatalogProductResponse
{
    [JsonProperty("product_filters")]
    public List<object> ProductFilters;

    [JsonProperty("products")]
    public List<Product> Products;

    [JsonProperty("response_groups")]
    public List<string> ResponseGroups;

    [JsonProperty("total_results")]
    public int TotalResults;

    public CatalogProductResponse( List<Product> products )
    {
        this.Products = products;
    }
}


