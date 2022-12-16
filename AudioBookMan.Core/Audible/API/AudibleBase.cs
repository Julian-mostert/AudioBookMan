using Flurl;

namespace AudioBookMan.Core.Audible.API
{
    public abstract class AudibleBase
    {
        protected readonly Url BaseUrl = new("https://api.audible.com/1.0/");

        protected static string CreateAggregatedList( IEnumerable<string> groups )
        {
            string groupList = groups.Aggregate(string.Empty, ( current, responseGroupValue ) => current + $"{responseGroupValue},");

            return groupList.Remove(groupList.Length - 1);
        }
    }
}
