
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorType
    {
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
    public static class OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorType value)
        {
            return value switch
            {
                OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputFile => "input_file",
                OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputImage => "input_image",
                OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputFile,
                "input_image" => OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputImage,
                "input_text" => OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}