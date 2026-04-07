
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicWebSearchToolUserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebSearchToolUserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebSearchToolUserLocationType value)
        {
            return value switch
            {
                AnthropicWebSearchToolUserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebSearchToolUserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => AnthropicWebSearchToolUserLocationType.Approximate,
                _ => null,
            };
        }
    }
}