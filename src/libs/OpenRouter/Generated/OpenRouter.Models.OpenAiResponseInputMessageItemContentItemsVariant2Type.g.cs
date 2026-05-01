
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_file
    /// </summary>
    public enum OpenAiResponseInputMessageItemContentItemsVariant2Type
    {
        /// <summary>
        /// input_file
        /// </summary>
        InputFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseInputMessageItemContentItemsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseInputMessageItemContentItemsVariant2Type value)
        {
            return value switch
            {
                OpenAiResponseInputMessageItemContentItemsVariant2Type.InputFile => "input_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItemsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "input_file" => OpenAiResponseInputMessageItemContentItemsVariant2Type.InputFile,
                _ => null,
            };
        }
    }
}