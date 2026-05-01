
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:image_generation
    /// </summary>
    public enum OutputItemsVariant14Type
    {
        /// <summary>
        /// openrouter:image_generation
        /// </summary>
        Openrouter_imageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant14Type value)
        {
            return value switch
            {
                OutputItemsVariant14Type.Openrouter_imageGeneration => "openrouter:image_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:image_generation" => OutputItemsVariant14Type.Openrouter_imageGeneration,
                _ => null,
            };
        }
    }
}