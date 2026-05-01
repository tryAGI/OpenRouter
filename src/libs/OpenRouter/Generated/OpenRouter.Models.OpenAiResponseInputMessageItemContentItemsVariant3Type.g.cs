
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_image
    /// </summary>
    public enum OpenAiResponseInputMessageItemContentItemsVariant3Type
    {
        /// <summary>
        /// input_image
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseInputMessageItemContentItemsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseInputMessageItemContentItemsVariant3Type value)
        {
            return value switch
            {
                OpenAiResponseInputMessageItemContentItemsVariant3Type.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItemsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => OpenAiResponseInputMessageItemContentItemsVariant3Type.InputImage,
                _ => null,
            };
        }
    }
}