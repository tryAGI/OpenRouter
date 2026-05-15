
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:fusion
    /// </summary>
    public enum OutputItemsVariant16Type
    {
        /// <summary>
        /// openrouter:fusion
        /// </summary>
        Openrouter_fusion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant16TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant16Type value)
        {
            return value switch
            {
                OutputItemsVariant16Type.Openrouter_fusion => "openrouter:fusion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant16Type? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:fusion" => OutputItemsVariant16Type.Openrouter_fusion,
                _ => null,
            };
        }
    }
}