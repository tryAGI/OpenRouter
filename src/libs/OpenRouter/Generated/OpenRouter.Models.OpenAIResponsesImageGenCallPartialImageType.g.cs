
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesImageGenCallPartialImageType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallPartialImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesImageGenCallPartialImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesImageGenCallPartialImageType value)
        {
            return value switch
            {
                OpenAIResponsesImageGenCallPartialImageType.ResponseImageGenerationCallPartialImage => "response.image_generation_call.partial_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesImageGenCallPartialImageType? ToEnum(string value)
        {
            return value switch
            {
                "response.image_generation_call.partial_image" => OpenAIResponsesImageGenCallPartialImageType.ResponseImageGenerationCallPartialImage,
                _ => null,
            };
        }
    }
}