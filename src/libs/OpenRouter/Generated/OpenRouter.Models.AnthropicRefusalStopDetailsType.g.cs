
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicRefusalStopDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicRefusalStopDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicRefusalStopDetailsType value)
        {
            return value switch
            {
                AnthropicRefusalStopDetailsType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicRefusalStopDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => AnthropicRefusalStopDetailsType.Refusal,
                _ => null,
            };
        }
    }
}