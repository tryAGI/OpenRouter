
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AlignmentChatImageType
    {
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlignmentChatImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentChatImageType value)
        {
            return value switch
            {
                AlignmentChatImageType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentChatImageType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => AlignmentChatImageType.ImageUrl,
                _ => null,
            };
        }
    }
}