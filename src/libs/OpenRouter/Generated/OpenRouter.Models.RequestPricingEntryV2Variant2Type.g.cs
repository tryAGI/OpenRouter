
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum RequestPricingEntryV2Variant2Type
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestPricingEntryV2Variant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestPricingEntryV2Variant2Type value)
        {
            return value switch
            {
                RequestPricingEntryV2Variant2Type.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestPricingEntryV2Variant2Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => RequestPricingEntryV2Variant2Type.WebSearch,
                _ => null,
            };
        }
    }
}