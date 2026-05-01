
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: image_url
    /// </summary>
    public enum ChatContentItemsVariant2Type
    {
        /// <summary>
        /// image_url
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContentItemsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentItemsVariant2Type value)
        {
            return value switch
            {
                ChatContentItemsVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentItemsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ChatContentItemsVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}