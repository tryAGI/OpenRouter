
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_image
    /// </summary>
    public enum BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3Type
    {
        /// <summary>
        /// input_image
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3Type value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3Type.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3Type.InputImage,
                _ => null,
            };
        }
    }
}