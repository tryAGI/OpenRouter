
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_audio
    /// </summary>
    public enum OpenAiResponseInputMessageItemContentItemsVariant1Type
    {
        /// <summary>
        /// input_audio
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseInputMessageItemContentItemsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseInputMessageItemContentItemsVariant1Type value)
        {
            return value switch
            {
                OpenAiResponseInputMessageItemContentItemsVariant1Type.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItemsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => OpenAiResponseInputMessageItemContentItemsVariant1Type.InputAudio,
                _ => null,
            };
        }
    }
}