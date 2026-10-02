
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesWebSearchCallSearchingType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseWebSearchCallSearching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesWebSearchCallSearchingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesWebSearchCallSearchingType value)
        {
            return value switch
            {
                OpenAIResponsesWebSearchCallSearchingType.ResponseWebSearchCallSearching => "response.web_search_call.searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesWebSearchCallSearchingType? ToEnum(string value)
        {
            return value switch
            {
                "response.web_search_call.searching" => OpenAIResponsesWebSearchCallSearchingType.ResponseWebSearchCallSearching,
                _ => null,
            };
        }
    }
}