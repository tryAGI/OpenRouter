
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesImageGenCallCompletedType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesImageGenCallCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesImageGenCallCompletedType value)
        {
            return value switch
            {
                OpenAIResponsesImageGenCallCompletedType.ResponseImageGenerationCallCompleted => "response.image_generation_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesImageGenCallCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "response.image_generation_call.completed" => OpenAIResponsesImageGenCallCompletedType.ResponseImageGenerationCallCompleted,
                _ => null,
            };
        }
    }
}