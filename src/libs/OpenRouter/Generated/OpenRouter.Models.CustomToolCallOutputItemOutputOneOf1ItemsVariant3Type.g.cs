
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_text
    /// </summary>
    public enum CustomToolCallOutputItemOutputOneOf1ItemsVariant3Type
    {
        /// <summary>
        /// input_text
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolCallOutputItemOutputOneOf1ItemsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolCallOutputItemOutputOneOf1ItemsVariant3Type value)
        {
            return value switch
            {
                CustomToolCallOutputItemOutputOneOf1ItemsVariant3Type.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolCallOutputItemOutputOneOf1ItemsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => CustomToolCallOutputItemOutputOneOf1ItemsVariant3Type.InputText,
                _ => null,
            };
        }
    }
}