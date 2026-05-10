
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType
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
    public static class BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputAudio => "input_audio",
                BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputFile => "input_file",
                BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputImage => "input_image",
                BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputAudio,
                "input_file" => BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputFile,
                "input_image" => BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputImage,
                "input_text" => BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}