using AudioBookMan.Core.Audnexus.DTO.Request;
using AudioBookMan.Core.Audnexus.DTO.Response;
using Flurl;
using Flurl.Http;

namespace AudioBookMan.Core.Audnexus.API;

public class Authors : AudnexusBase
{
    private const    string ApiSection = "authors";
    private readonly Url    _audnexusAuthorProductUrl;

    public Authors()
    {
        this._audnexusAuthorProductUrl = this.BaseUrl.AppendPathSegments(ApiSection);
    }

    public Task<FindAuthorsByNameResponse> GetAuthorByName( FindAuthorByNameRequest request )
    {
        Url callUrl = this._audnexusAuthorProductUrl.SetQueryParams(
                                                                    new
                                                                    {
                                                                        name   = request.AuthorName,
                                                                        region = request.RegionType
                                                                    }
                                                                   );

        return callUrl.GetJsonAsync<FindAuthorsByNameResponse>();
    }

    public Task<FindAuthorByIdResponse> GetAuthorById( FindAuthorByIdRequest request )
    {
        Url callUrl = this._audnexusAuthorProductUrl.AppendPathSegment(request.ASIN).
                           SetQueryParams(
                                          new
                                          {
                                              update = request.Update,
                                              region = request.RegionType
                                          }
                                         );

        return callUrl.GetJsonAsync<FindAuthorByIdResponse>();
    }

    public Task<FindAuthorByIdResponse> GetSearchAuthorByName( FindAuthorByNameRequest request )
    {
        Url callUrl = this._audnexusAuthorProductUrl
                          .SetQueryParam("name", request.AuthorName, true).
                           SetQueryParam("region", request.RegionType);

        return callUrl.GetJsonAsync<FindAuthorByIdResponse>();
    }
}
