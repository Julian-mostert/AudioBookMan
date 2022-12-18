using AudioBookMan.Core.Audnexus.DTO.Enum;

namespace AudioBookMan.Core.Audnexus.DTO.Request;

public class FindAuthorByIdRequest
{
    public string     ASIN       { get; set; }
    public RegionType RegionType { get; set; } = RegionType.Us;
    public UpdateType Update     { get; set; }
}


