using AudioBookMan.Core.Audnexus.DTO.Request;
using AudioBookMan.Core.Audnexus.DTO.Response;
using Flurl;
using Flurl.Http;

namespace AudioBookMan.Core.Audnexus.API;

public class Books : AudnexusBase
{
    private const    string ApiSection = "books";
    private readonly Url    _audnexusAuthorProductUrl;

    public Books()
    {
        this._audnexusAuthorProductUrl = this.BaseUrl.AppendPathSegments(ApiSection);
    }

    public Task<FindAuthorByIdResponse> GetBooksById( GetBookByIdRequest request )
    {
        Url callUrl = this._audnexusAuthorProductUrl.AppendPathSegment(request.ASIN).
                           SetQueryParams(
                                          new
                                          {
                                              seedAuthors = request.SeedAuthors,
                                              update      = request.Update,
                                              region      = request.RegionType
                                          }
                                         );

        return callUrl.GetJsonAsync<FindAuthorByIdResponse>();
    }
}

