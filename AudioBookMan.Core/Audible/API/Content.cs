using AudioBookMan.Core.Audible.DTO.Request;
using AudioBookMan.Core.Audible.DTO.Response;
using Flurl;
using Flurl.Http;

namespace AudioBookMan.Core.Audible.API;

public class Content : AudibleBase
{
    private const    string ApiSection = "content";
    private readonly Url    _audibleCatalogProductUrl;

    public Content()
    {
        this._audibleCatalogProductUrl = this.BaseUrl.AppendPathSegments(ApiSection);
    }

    public Task<CatalogResponse> GetMetaDataByAsin( CatalogProductByAsinRequest request )
    {
        string responseGroupList = CreateAggregatedList(request.ResponseGroups);
        Url callUrl = this._audibleCatalogProductUrl.AppendPathSegment("products").
                           AppendPathSegment($"{request.Asins}").
                           SetQueryParam("response_groups", responseGroupList);

        return callUrl.GetJsonAsync<CatalogResponse>();
    }

    public Task<ContentMetaDataResponse> GetChapterInfoByAsin( CatalogChaptersByAsinRequest request )
    {
        string responseGroupList = CreateAggregatedList(request.ResponseGroups);
        Url callUrl = this._audibleCatalogProductUrl.AppendPathSegment($"{request.Asins}").
                           AppendPathSegment("metadata").
                           SetQueryParam("response_groups", responseGroupList).
                           SetQueryParam("quality", request.Quality);

        return callUrl.GetJsonAsync<ContentMetaDataResponse>();
    }
}


