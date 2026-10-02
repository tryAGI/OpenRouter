
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicFileDeletedShape
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicFileDeletedShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicFileDeletedShape value)
        {
            return value switch
            {
                AnthropicFileDeletedShape.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicFileDeletedShape? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => AnthropicFileDeletedShape.Anthropic,
                _ => null,
            };
        }
    }
}