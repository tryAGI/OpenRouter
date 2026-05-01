
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_audio
    /// </summary>
    public enum BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1Type
    {
        /// <summary>
        /// input_audio
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1Type value)
        {
            return value switch
            {
                BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1Type.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1Type.InputAudio,
                _ => null,
            };
        }
    }
}