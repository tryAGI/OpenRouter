
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum InputPricingEntryV2Variant3Type
    {
        /// <summary>
        ///
        /// </summary>
        CacheWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputPricingEntryV2Variant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputPricingEntryV2Variant3Type value)
        {
            return value switch
            {
                InputPricingEntryV2Variant3Type.CacheWrite => "cache_write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputPricingEntryV2Variant3Type? ToEnum(string value)
        {
            return value switch
            {
                "cache_write" => InputPricingEntryV2Variant3Type.CacheWrite,
                _ => null,
            };
        }
    }
}