
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicMessageUsageIterationType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicMessageUsageIterationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicMessageUsageIterationType value)
        {
            return value switch
            {
                AnthropicMessageUsageIterationType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicMessageUsageIterationType? ToEnum(string value)
        {
            return value switch
            {
                "message" => AnthropicMessageUsageIterationType.Message,
                _ => null,
            };
        }
    }
}