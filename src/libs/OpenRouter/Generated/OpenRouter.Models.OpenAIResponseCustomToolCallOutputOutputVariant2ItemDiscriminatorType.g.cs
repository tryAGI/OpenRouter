
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType
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
    public static class OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType.InputFile => "input_file",
                OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType.InputImage => "input_image",
                OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType.InputFile,
                "input_image" => OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType.InputImage,
                "input_text" => OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}