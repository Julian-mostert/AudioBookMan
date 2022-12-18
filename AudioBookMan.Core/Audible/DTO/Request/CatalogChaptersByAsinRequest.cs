namespace AudioBookMan.Core.Audible.DTO.Request;

public class CatalogChaptersByAsinRequest
{
    public CatalogChaptersByAsinRequest()
    {
        this.ResponseGroups = new List<string>
                              {
                                  Const.ResponseGroups.ChapterInfo,
                                  Const.ResponseGroups.AlwaysReturned,
                                  Const.ResponseGroups.ContentReference,
                                  Const.ResponseGroups.ContentUrl
                              };
        this.Quality = Const.Quality.High;
    }

    public IEnumerable<string> ResponseGroups { get; set; }
    public string              Quality        { get; set; }
    public string              Asins          { get; set; }
}


