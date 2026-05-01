
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_text
    /// </summary>
    public enum OpenAiResponseInputMessageItemContentItemsVariant4Type
    {
        /// <summary>
        /// input_text
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseInputMessageItemContentItemsVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseInputMessageItemContentItemsVariant4Type value)
        {
            return value switch
            {
                OpenAiResponseInputMessageItemContentItemsVariant4Type.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItemsVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => OpenAiResponseInputMessageItemContentItemsVariant4Type.InputText,
                _ => null,
            };
        }
    }
}