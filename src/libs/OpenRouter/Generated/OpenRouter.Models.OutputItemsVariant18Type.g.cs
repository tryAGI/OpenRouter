
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:image_generation
    /// </summary>
    public enum OutputItemsVariant18Type
    {
        /// <summary>
        /// openrouter:image_generation
        /// </summary>
        Openrouter_imageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant18TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant18Type value)
        {
            return value switch
            {
                OutputItemsVariant18Type.Openrouter_imageGeneration => "openrouter:image_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant18Type? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:image_generation" => OutputItemsVariant18Type.Openrouter_imageGeneration,
                _ => null,
            };
        }
    }
}