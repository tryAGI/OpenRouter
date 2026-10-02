
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType
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
    public static class OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType.InputFile => "input_file",
                OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType.InputImage => "input_image",
                OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType.InputFile,
                "input_image" => OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType.InputImage,
                "input_text" => OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}