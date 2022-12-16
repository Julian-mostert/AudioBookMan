using AudioBookMan.Core.Audible.DTO.Requests;
using AudioBookMan.Core.Audible.DTO.Response;
using AudioBookMan.Core.Audible.Extensions;
using Flurl;
using Flurl.Http;

namespace AudioBookMan.Core.Audible.API
{
    public class AudibleCatalogProduct : AudibleBase
    {
        private const string ApiSection = "catalog";
        private readonly Url _audibleCatalogProductUrl;

        public AudibleCatalogProduct()
        {
            this._audibleCatalogProductUrl = this.BaseUrl.AppendPathSegments(ApiSection);
        }

        public Task<CatalogResponse> GetProductsByAsin( CatalogProductByAsinRequest request )
        {
            string responseGroupList = CreateAggregatedList(request.ResponseGroups);
            Url callUrl = this._audibleCatalogProductUrl.AppendPathSegment("products")
                              .AppendPathSegment($"{request.Asins}")
                              .SetQueryParam("response_groups", responseGroupList);

            return callUrl.GetJsonAsync<CatalogResponse>();
        }

        public Task<CatalogProductResponse> GetProducts( CatalogProductsRequest request )
        {
            string responseGroupList = CreateAggregatedList(request.ResponseGroups);
            string productsSortBy    = CreateAggregatedList(request.ProductsSortBy);
            Url callUrl = this._audibleCatalogProductUrl.AppendPathSegment("products")
                              .SetQueryParam("response_groups", responseGroupList)
                              .SetQueryParam("products_sort_by", productsSortBy)
                              .SetQueryParam("num_results", request.NumberOfResults)
                              .AddAudibleParam(request.Narrator, "narrator")
                              .AddAudibleParam(request.Author, "author")
                              .AddAudibleParam(request.Keywords, "keywords")
                              .AddAudibleParam(request.Publisher, "publisher")
                              .AddAudibleParam(request.Title, "title");

            return callUrl.GetJsonAsync<CatalogProductResponse>();
        }
    }
}
