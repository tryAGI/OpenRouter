
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCacheControlDirectiveType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCacheControlDirectiveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCacheControlDirectiveType value)
        {
            return value switch
            {
                AnthropicCacheControlDirectiveType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCacheControlDirectiveType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => AnthropicCacheControlDirectiveType.Ephemeral,
                _ => null,
            };
        }
    }
}