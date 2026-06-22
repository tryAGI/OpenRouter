
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Background treatment. `transparent` requires an output_format that supports alpha (png or webp).
    /// </summary>
    public enum ImageGenerationRequestBackground
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Opaque,
        /// <summary>
        /// 
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestBackground value)
        {
            return value switch
            {
                ImageGenerationRequestBackground.Auto => "auto",
                ImageGenerationRequestBackground.Opaque => "opaque",
                ImageGenerationRequestBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageGenerationRequestBackground.Auto,
                "opaque" => ImageGenerationRequestBackground.Opaque,
                "transparent" => ImageGenerationRequestBackground.Transparent,
                _ => null,
            };
        }
    }
}