
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicFileShape
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicFileShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicFileShape value)
        {
            return value switch
            {
                AnthropicFileShape.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicFileShape? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => AnthropicFileShape.Anthropic,
                _ => null,
            };
        }
    }
}