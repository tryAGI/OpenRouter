
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Encoding of the returned image bytes. Most models produce raster formats (png, jpeg, webp). SVG is supported by vectorization models (e.g. Quiver) — the SVG markup is UTF-8 base64-encoded in `b64_json`.
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
        Svg,
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
                ImageGenerationRequestOutputFormat.Svg => "svg",
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
                "svg" => ImageGenerationRequestOutputFormat.Svg,
                "webp" => ImageGenerationRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}