
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesImageGenCallGeneratingType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallGenerating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesImageGenCallGeneratingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesImageGenCallGeneratingType value)
        {
            return value switch
            {
                OpenAIResponsesImageGenCallGeneratingType.ResponseImageGenerationCallGenerating => "response.image_generation_call.generating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesImageGenCallGeneratingType? ToEnum(string value)
        {
            return value switch
            {
                "response.image_generation_call.generating" => OpenAIResponsesImageGenCallGeneratingType.ResponseImageGenerationCallGenerating,
                _ => null,
            };
        }
    }
}