
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: page_location
    /// </summary>
    public enum AnthropicTextBlockParamCitationsItemsVariant3Type
    {
        /// <summary>
        /// page_location
        /// </summary>
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextBlockParamCitationsItemsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextBlockParamCitationsItemsVariant3Type value)
        {
            return value switch
            {
                AnthropicTextBlockParamCitationsItemsVariant3Type.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextBlockParamCitationsItemsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "page_location" => AnthropicTextBlockParamCitationsItemsVariant3Type.PageLocation,
                _ => null,
            };
        }
    }
}