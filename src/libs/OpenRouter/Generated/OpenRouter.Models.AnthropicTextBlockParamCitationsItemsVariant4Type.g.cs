
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: search_result_location
    /// </summary>
    public enum AnthropicTextBlockParamCitationsItemsVariant4Type
    {
        /// <summary>
        /// search_result_location
        /// </summary>
        SearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextBlockParamCitationsItemsVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextBlockParamCitationsItemsVariant4Type value)
        {
            return value switch
            {
                AnthropicTextBlockParamCitationsItemsVariant4Type.SearchResultLocation => "search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextBlockParamCitationsItemsVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "search_result_location" => AnthropicTextBlockParamCitationsItemsVariant4Type.SearchResultLocation,
                _ => null,
            };
        }
    }
}