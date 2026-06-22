
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Rendering quality. Providers without a quality knob ignore this.
    /// </summary>
    public enum ImageGenerationRequestQuality
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestQuality value)
        {
            return value switch
            {
                ImageGenerationRequestQuality.Auto => "auto",
                ImageGenerationRequestQuality.High => "high",
                ImageGenerationRequestQuality.Low => "low",
                ImageGenerationRequestQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageGenerationRequestQuality.Auto,
                "high" => ImageGenerationRequestQuality.High,
                "low" => ImageGenerationRequestQuality.Low,
                "medium" => ImageGenerationRequestQuality.Medium,
                _ => null,
            };
        }
    }
}