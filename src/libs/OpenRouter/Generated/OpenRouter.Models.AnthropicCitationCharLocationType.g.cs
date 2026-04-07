
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCitationCharLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        CharLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCitationCharLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCitationCharLocationType value)
        {
            return value switch
            {
                AnthropicCitationCharLocationType.CharLocation => "char_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCitationCharLocationType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => AnthropicCitationCharLocationType.CharLocation,
                _ => null,
            };
        }
    }
}