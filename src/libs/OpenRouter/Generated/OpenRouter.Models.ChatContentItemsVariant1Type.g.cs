
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: file
    /// </summary>
    public enum ChatContentItemsVariant1Type
    {
        /// <summary>
        /// file
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContentItemsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentItemsVariant1Type value)
        {
            return value switch
            {
                ChatContentItemsVariant1Type.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentItemsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "file" => ChatContentItemsVariant1Type.File,
                _ => null,
            };
        }
    }
}