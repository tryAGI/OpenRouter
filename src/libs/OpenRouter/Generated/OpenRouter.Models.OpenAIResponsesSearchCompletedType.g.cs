
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesSearchCompletedType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseWebSearchCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesSearchCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesSearchCompletedType value)
        {
            return value switch
            {
                OpenAIResponsesSearchCompletedType.ResponseWebSearchCallCompleted => "response.web_search_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesSearchCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "response.web_search_call.completed" => OpenAIResponsesSearchCompletedType.ResponseWebSearchCallCompleted,
                _ => null,
            };
        }
    }
}