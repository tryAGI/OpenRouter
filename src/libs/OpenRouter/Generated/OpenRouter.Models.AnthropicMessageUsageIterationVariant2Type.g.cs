
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicMessageUsageIterationVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicMessageUsageIterationVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicMessageUsageIterationVariant2Type value)
        {
            return value switch
            {
                AnthropicMessageUsageIterationVariant2Type.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicMessageUsageIterationVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "message" => AnthropicMessageUsageIterationVariant2Type.Message,
                _ => null,
            };
        }
    }
}