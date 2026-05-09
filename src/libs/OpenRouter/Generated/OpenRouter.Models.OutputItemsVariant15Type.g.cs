
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:image_generation
    /// </summary>
    public enum OutputItemsVariant15Type
    {
        /// <summary>
        /// openrouter:image_generation
        /// </summary>
        Openrouter_imageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant15TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant15Type value)
        {
            return value switch
            {
                OutputItemsVariant15Type.Openrouter_imageGeneration => "openrouter:image_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant15Type? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:image_generation" => OutputItemsVariant15Type.Openrouter_imageGeneration,
                _ => null,
            };
        }
    }
}