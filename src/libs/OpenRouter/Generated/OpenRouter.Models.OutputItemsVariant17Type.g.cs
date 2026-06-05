
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:fusion
    /// </summary>
    public enum OutputItemsVariant17Type
    {
        /// <summary>
        /// openrouter:fusion
        /// </summary>
        Openrouter_fusion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant17TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant17Type value)
        {
            return value switch
            {
                OutputItemsVariant17Type.Openrouter_fusion => "openrouter:fusion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant17Type? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:fusion" => OutputItemsVariant17Type.Openrouter_fusion,
                _ => null,
            };
        }
    }
}