
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The event type
    /// </summary>
    public enum ImageGenStreamErrorEventType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenStreamErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenStreamErrorEventType value)
        {
            return value switch
            {
                ImageGenStreamErrorEventType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenStreamErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ImageGenStreamErrorEventType.Error,
                _ => null,
            };
        }
    }
}