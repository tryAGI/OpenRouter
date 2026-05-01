
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_text
    /// </summary>
    public enum BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4Type
    {
        /// <summary>
        /// input_text
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4Type value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4Type.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4Type.InputText,
                _ => null,
            };
        }
    }
}