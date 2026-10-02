
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesWebSearchCallInProgressType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseWebSearchCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesWebSearchCallInProgressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesWebSearchCallInProgressType value)
        {
            return value switch
            {
                OpenAIResponsesWebSearchCallInProgressType.ResponseWebSearchCallInProgress => "response.web_search_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesWebSearchCallInProgressType? ToEnum(string value)
        {
            return value switch
            {
                "response.web_search_call.in_progress" => OpenAIResponsesWebSearchCallInProgressType.ResponseWebSearchCallInProgress,
                _ => null,
            };
        }
    }
}