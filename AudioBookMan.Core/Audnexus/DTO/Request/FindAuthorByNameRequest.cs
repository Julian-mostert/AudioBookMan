using AudioBookMan.Core.Audnexus.DTO.Enum;

namespace AudioBookMan.Core.Audnexus.DTO.Request;

public class FindAuthorByNameRequest
{
    public string     AuthorName { get; set; }
    public RegionType RegionType { get; set; } = RegionType.Us;
}



