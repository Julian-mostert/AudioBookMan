using Flurl;

namespace AudioBookMan.Core.Audnexus.API;

public abstract class AudnexusBase
{
    protected readonly Url BaseUrl = new("https://api.audnex.us/");

    protected static string CreateAggregatedList( IEnumerable<string> groups )
    {
        string groupList = groups.Aggregate(string.Empty, ( current, responseGroupValue ) => current + $"{responseGroupValue},");

        return groupList.Remove(groupList.Length - 1);
    }
}



