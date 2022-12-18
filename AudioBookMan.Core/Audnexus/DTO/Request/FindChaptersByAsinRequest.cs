using AudioBookMan.Core.Audnexus.DTO.Enum;

namespace AudioBookMan.Core.Audnexus.DTO.Request;

public class FindChaptersByAsinRequest
{
    public string     ASIN       { get; set; }
    public UpdateType Update     { get; set; } = UpdateType.Update;
    public RegionType RegionType { get; set; } = RegionType.Us;
}
