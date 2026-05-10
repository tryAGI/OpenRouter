
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponseInputMessageItemContentItemsDiscriminatorType
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
    public static class OpenAiResponseInputMessageItemContentItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseInputMessageItemContentItemsDiscriminatorType value)
        {
            return value switch
            {
                OpenAiResponseInputMessageItemContentItemsDiscriminatorType.InputAudio => "input_audio",
                OpenAiResponseInputMessageItemContentItemsDiscriminatorType.InputFile => "input_file",
                OpenAiResponseInputMessageItemContentItemsDiscriminatorType.InputImage => "input_image",
                OpenAiResponseInputMessageItemContentItemsDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => OpenAiResponseInputMessageItemContentItemsDiscriminatorType.InputAudio,
                "input_file" => OpenAiResponseInputMessageItemContentItemsDiscriminatorType.InputFile,
                "input_image" => OpenAiResponseInputMessageItemContentItemsDiscriminatorType.InputImage,
                "input_text" => OpenAiResponseInputMessageItemContentItemsDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}