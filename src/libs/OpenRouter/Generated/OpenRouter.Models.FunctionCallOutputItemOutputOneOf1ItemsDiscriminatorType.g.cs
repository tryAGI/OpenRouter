
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType
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
    public static class FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType value)
        {
            return value switch
            {
                FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputFile => "input_file",
                FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputImage => "input_image",
                FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputFile,
                "input_image" => FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputImage,
                "input_text" => FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}