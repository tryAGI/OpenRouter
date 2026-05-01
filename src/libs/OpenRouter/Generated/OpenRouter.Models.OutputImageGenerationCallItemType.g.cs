
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputImageGenerationCallItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageGenerationCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputImageGenerationCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputImageGenerationCallItemType value)
        {
            return value switch
            {
                OutputImageGenerationCallItemType.ImageGenerationCall => "image_generation_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputImageGenerationCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation_call" => OutputImageGenerationCallItemType.ImageGenerationCall,
                _ => null,
            };
        }
    }
}