using AudioBookMan.Core.Audnexus.DTO.Enum;

namespace AudioBookMan.Core.Audnexus.DTO.Request;

public class GetBookByIdRequest
{
    public string          ASIN        { get; set; }
    public SeedAuthorsType SeedAuthors { get; set; } = SeedAuthorsType.Yes;
    public UpdateType      Update      { get; set; } = UpdateType.Update;
    public RegionType      RegionType  { get; set; } = RegionType.Us;
}