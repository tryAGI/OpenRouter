
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_image
    /// </summary>
    public enum OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2Type
    {
        /// <summary>
        /// input_image
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2Type value)
        {
            return value switch
            {
                OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2Type.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2Type.InputImage,
                _ => null,
            };
        }
    }
}