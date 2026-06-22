
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Normalized resolution tier of the generated image. Concrete pixel dimensions are derived per-provider.
    /// </summary>
    public enum ImageGenerationRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x4k,
        /// <summary>
        /// 
        /// </summary>
        x512,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestResolution value)
        {
            return value switch
            {
                ImageGenerationRequestResolution.x1k => "1K",
                ImageGenerationRequestResolution.x2k => "2K",
                ImageGenerationRequestResolution.x4k => "4K",
                ImageGenerationRequestResolution.x512 => "512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => ImageGenerationRequestResolution.x1k,
                "2K" => ImageGenerationRequestResolution.x2k,
                "4K" => ImageGenerationRequestResolution.x4k,
                "512" => ImageGenerationRequestResolution.x512,
                _ => null,
            };
        }
    }
}