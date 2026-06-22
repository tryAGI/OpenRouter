
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Normalized aspect ratio of the generated image. Providers clamp to their supported subset.
    /// </summary>
    public enum ImageGenerationRequestAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x195_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x1_2,
        /// <summary>
        /// 
        /// </summary>
        x1_4,
        /// <summary>
        /// 
        /// </summary>
        x1_8,
        /// <summary>
        /// 
        /// </summary>
        x20_9,
        /// <summary>
        /// 
        /// </summary>
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x2_1,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_1,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        x5_4,
        /// <summary>
        /// 
        /// </summary>
        x8_1,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
        /// <summary>
        /// 
        /// </summary>
        x9_195,
        /// <summary>
        /// 
        /// </summary>
        x9_20,
        /// <summary>
        /// 
        /// </summary>
        x9_21,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestAspectRatio value)
        {
            return value switch
            {
                ImageGenerationRequestAspectRatio.x16_9 => "16:9",
                ImageGenerationRequestAspectRatio.x195_9 => "19.5:9",
                ImageGenerationRequestAspectRatio.x1_1 => "1:1",
                ImageGenerationRequestAspectRatio.x1_2 => "1:2",
                ImageGenerationRequestAspectRatio.x1_4 => "1:4",
                ImageGenerationRequestAspectRatio.x1_8 => "1:8",
                ImageGenerationRequestAspectRatio.x20_9 => "20:9",
                ImageGenerationRequestAspectRatio.x21_9 => "21:9",
                ImageGenerationRequestAspectRatio.x2_1 => "2:1",
                ImageGenerationRequestAspectRatio.x2_3 => "2:3",
                ImageGenerationRequestAspectRatio.x3_2 => "3:2",
                ImageGenerationRequestAspectRatio.x3_4 => "3:4",
                ImageGenerationRequestAspectRatio.x4_1 => "4:1",
                ImageGenerationRequestAspectRatio.x4_3 => "4:3",
                ImageGenerationRequestAspectRatio.x4_5 => "4:5",
                ImageGenerationRequestAspectRatio.x5_4 => "5:4",
                ImageGenerationRequestAspectRatio.x8_1 => "8:1",
                ImageGenerationRequestAspectRatio.x9_16 => "9:16",
                ImageGenerationRequestAspectRatio.x9_195 => "9:19.5",
                ImageGenerationRequestAspectRatio.x9_20 => "9:20",
                ImageGenerationRequestAspectRatio.x9_21 => "9:21",
                ImageGenerationRequestAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ImageGenerationRequestAspectRatio.x16_9,
                "19.5:9" => ImageGenerationRequestAspectRatio.x195_9,
                "1:1" => ImageGenerationRequestAspectRatio.x1_1,
                "1:2" => ImageGenerationRequestAspectRatio.x1_2,
                "1:4" => ImageGenerationRequestAspectRatio.x1_4,
                "1:8" => ImageGenerationRequestAspectRatio.x1_8,
                "20:9" => ImageGenerationRequestAspectRatio.x20_9,
                "21:9" => ImageGenerationRequestAspectRatio.x21_9,
                "2:1" => ImageGenerationRequestAspectRatio.x2_1,
                "2:3" => ImageGenerationRequestAspectRatio.x2_3,
                "3:2" => ImageGenerationRequestAspectRatio.x3_2,
                "3:4" => ImageGenerationRequestAspectRatio.x3_4,
                "4:1" => ImageGenerationRequestAspectRatio.x4_1,
                "4:3" => ImageGenerationRequestAspectRatio.x4_3,
                "4:5" => ImageGenerationRequestAspectRatio.x4_5,
                "5:4" => ImageGenerationRequestAspectRatio.x5_4,
                "8:1" => ImageGenerationRequestAspectRatio.x8_1,
                "9:16" => ImageGenerationRequestAspectRatio.x9_16,
                "9:19.5" => ImageGenerationRequestAspectRatio.x9_195,
                "9:20" => ImageGenerationRequestAspectRatio.x9_20,
                "9:21" => ImageGenerationRequestAspectRatio.x9_21,
                "auto" => ImageGenerationRequestAspectRatio.Auto,
                _ => null,
            };
        }
    }
}