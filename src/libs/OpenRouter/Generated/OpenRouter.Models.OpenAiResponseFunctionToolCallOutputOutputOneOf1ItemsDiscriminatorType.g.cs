
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorType
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
    public static class OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorType value)
        {
            return value switch
            {
                OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputFile => "input_file",
                OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputImage => "input_image",
                OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputFile,
                "input_image" => OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputImage,
                "input_text" => OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}