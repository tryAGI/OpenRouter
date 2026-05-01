
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: search_result_location
    /// </summary>
    public enum AnthropicTextCitationVariant4Type
    {
        /// <summary>
        /// search_result_location
        /// </summary>
        SearchResultLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextCitationVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextCitationVariant4Type value)
        {
            return value switch
            {
                AnthropicTextCitationVariant4Type.SearchResultLocation => "search_result_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextCitationVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "search_result_location" => AnthropicTextCitationVariant4Type.SearchResultLocation,
                _ => null,
            };
        }
    }
}