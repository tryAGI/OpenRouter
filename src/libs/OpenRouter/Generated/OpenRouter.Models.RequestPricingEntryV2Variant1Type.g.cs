
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum RequestPricingEntryV2Variant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Request,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestPricingEntryV2Variant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestPricingEntryV2Variant1Type value)
        {
            return value switch
            {
                RequestPricingEntryV2Variant1Type.Request => "request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestPricingEntryV2Variant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request" => RequestPricingEntryV2Variant1Type.Request,
                _ => null,
            };
        }
    }
}