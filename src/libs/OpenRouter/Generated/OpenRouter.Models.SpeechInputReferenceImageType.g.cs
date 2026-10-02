
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechInputReferenceImageType
    {
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechInputReferenceImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechInputReferenceImageType value)
        {
            return value switch
            {
                SpeechInputReferenceImageType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechInputReferenceImageType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => SpeechInputReferenceImageType.ImageUrl,
                _ => null,
            };
        }
    }
}