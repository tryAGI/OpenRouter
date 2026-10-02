
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesImageGenCallInProgressType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesImageGenCallInProgressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesImageGenCallInProgressType value)
        {
            return value switch
            {
                OpenAIResponsesImageGenCallInProgressType.ResponseImageGenerationCallInProgress => "response.image_generation_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesImageGenCallInProgressType? ToEnum(string value)
        {
            return value switch
            {
                "response.image_generation_call.in_progress" => OpenAIResponsesImageGenCallInProgressType.ResponseImageGenerationCallInProgress,
                _ => null,
            };
        }
    }
}