
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType
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
    public static class CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType value)
        {
            return value switch
            {
                CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputFile => "input_file",
                CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputImage => "input_image",
                CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputFile,
                "input_image" => CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputImage,
                "input_text" => CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}