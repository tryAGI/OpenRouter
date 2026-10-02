
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponseInputMessageItemContentItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudio,
        /// <summary>
        ///
        /// </summary>
        InputFile,
        /// <summary>
        ///
        /// </summary>
        InputImage,
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponseInputMessageItemContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponseInputMessageItemContentItemDiscriminatorType value)
        {
            return value switch
            {
                OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputAudio => "input_audio",
                OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputFile => "input_file",
                OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputImage => "input_image",
                OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponseInputMessageItemContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputAudio,
                "input_file" => OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputFile,
                "input_image" => OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputImage,
                "input_text" => OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}