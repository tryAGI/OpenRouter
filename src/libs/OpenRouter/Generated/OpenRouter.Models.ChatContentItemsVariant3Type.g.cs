
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: input_audio
    /// </summary>
    public enum ChatContentItemsVariant3Type
    {
        /// <summary>
        /// input_audio
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContentItemsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentItemsVariant3Type value)
        {
            return value switch
            {
                ChatContentItemsVariant3Type.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentItemsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => ChatContentItemsVariant3Type.InputAudio,
                _ => null,
            };
        }
    }
}