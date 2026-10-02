
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType
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
    public static class BaseInputsVariant2ItemContentVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType.InputAudio => "input_audio",
                BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType.InputFile => "input_file",
                BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType.InputImage => "input_image",
                BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType.InputAudio,
                "input_file" => BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType.InputFile,
                "input_image" => BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType.InputImage,
                "input_text" => BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}