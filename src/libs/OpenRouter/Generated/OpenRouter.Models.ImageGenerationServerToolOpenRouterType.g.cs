
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageGenerationServerToolOpenRouterType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_imageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolOpenRouterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolOpenRouterType value)
        {
            return value switch
            {
                ImageGenerationServerToolOpenRouterType.Openrouter_imageGeneration => "openrouter:image_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolOpenRouterType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:image_generation" => ImageGenerationServerToolOpenRouterType.Openrouter_imageGeneration,
                _ => null,
            };
        }
    }
}