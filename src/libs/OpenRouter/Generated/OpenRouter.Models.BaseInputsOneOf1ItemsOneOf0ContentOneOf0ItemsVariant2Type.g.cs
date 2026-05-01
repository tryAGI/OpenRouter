
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_file
    /// </summary>
    public enum BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2Type
    {
        /// <summary>
        /// input_file
        /// </summary>
        InputFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2Type value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2Type.InputFile => "input_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2Type.InputFile,
                _ => null,
            };
        }
    }
}