
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_file
    /// </summary>
    public enum CustomToolCallOutputItemOutputOneOf1ItemsVariant1Type
    {
        /// <summary>
        /// input_file
        /// </summary>
        InputFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolCallOutputItemOutputOneOf1ItemsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolCallOutputItemOutputOneOf1ItemsVariant1Type value)
        {
            return value switch
            {
                CustomToolCallOutputItemOutputOneOf1ItemsVariant1Type.InputFile => "input_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolCallOutputItemOutputOneOf1ItemsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => CustomToolCallOutputItemOutputOneOf1ItemsVariant1Type.InputFile,
                _ => null,
            };
        }
    }
}