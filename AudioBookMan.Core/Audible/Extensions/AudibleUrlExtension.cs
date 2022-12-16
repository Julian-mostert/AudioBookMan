using Flurl;

namespace AudioBookMan.Core.Audible.Extensions
{
    public static class AudibleUrlExtension
    {
        public static Url AddAudibleParam( this Url i, string requestValue, string paramName )
        {
            if(!string.IsNullOrEmpty(requestValue))
            {
                i = i.SetQueryParam(paramName, requestValue);
            }

            return i;
        }
    }
}
