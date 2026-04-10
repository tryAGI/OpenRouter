
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputImageGenerationServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_imageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputImageGenerationServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputImageGenerationServerToolItemType value)
        {
            return value switch
            {
                OutputImageGenerationServerToolItemType.Openrouter_imageGeneration => "openrouter:image_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputImageGenerationServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:image_generation" => OutputImageGenerationServerToolItemType.Openrouter_imageGeneration,
                _ => null,
            };
        }
    }
}