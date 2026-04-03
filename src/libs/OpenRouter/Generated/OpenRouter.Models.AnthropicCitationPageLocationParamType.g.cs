
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCitationPageLocationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCitationPageLocationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCitationPageLocationParamType value)
        {
            return value switch
            {
                AnthropicCitationPageLocationParamType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCitationPageLocationParamType? ToEnum(string value)
        {
            return value switch
            {
                "page_location" => AnthropicCitationPageLocationParamType.PageLocation,
                _ => null,
            };
        }
    }
}