
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Encoding of the returned image bytes.
    /// </summary>
    public enum ImageGenerationRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestOutputFormat value)
        {
            return value switch
            {
                ImageGenerationRequestOutputFormat.Jpeg => "jpeg",
                ImageGenerationRequestOutputFormat.Png => "png",
                ImageGenerationRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => ImageGenerationRequestOutputFormat.Jpeg,
                "png" => ImageGenerationRequestOutputFormat.Png,
                "webp" => ImageGenerationRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}