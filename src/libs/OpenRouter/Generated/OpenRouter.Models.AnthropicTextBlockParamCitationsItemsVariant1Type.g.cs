
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: char_location
    /// </summary>
    public enum AnthropicTextBlockParamCitationsItemsVariant1Type
    {
        /// <summary>
        /// char_location
        /// </summary>
        CharLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextBlockParamCitationsItemsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextBlockParamCitationsItemsVariant1Type value)
        {
            return value switch
            {
                AnthropicTextBlockParamCitationsItemsVariant1Type.CharLocation => "char_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextBlockParamCitationsItemsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => AnthropicTextBlockParamCitationsItemsVariant1Type.CharLocation,
                _ => null,
            };
        }
    }
}