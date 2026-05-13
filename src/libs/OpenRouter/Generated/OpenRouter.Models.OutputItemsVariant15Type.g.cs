
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:fusion
    /// </summary>
    public enum OutputItemsVariant15Type
    {
        /// <summary>
        /// openrouter:fusion
        /// </summary>
        Openrouter_fusion,
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
                OutputItemsVariant15Type.Openrouter_fusion => "openrouter:fusion",
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
                "openrouter:fusion" => OutputItemsVariant15Type.Openrouter_fusion,
                _ => null,
            };
        }
    }
}