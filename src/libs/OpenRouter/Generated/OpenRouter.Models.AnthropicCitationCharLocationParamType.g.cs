
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCitationCharLocationParamType
    {
        /// <summary>
        /// 
        /// </summary>
        CharLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCitationCharLocationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCitationCharLocationParamType value)
        {
            return value switch
            {
                AnthropicCitationCharLocationParamType.CharLocation => "char_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCitationCharLocationParamType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => AnthropicCitationCharLocationParamType.CharLocation,
                _ => null,
            };
        }
    }
}