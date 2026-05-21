
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebFetchPluginId
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebFetchPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchPluginId value)
        {
            return value switch
            {
                WebFetchPluginId.WebFetch => "web-fetch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchPluginId? ToEnum(string value)
        {
            return value switch
            {
                "web-fetch" => WebFetchPluginId.WebFetch,
                _ => null,
            };
        }
    }
}