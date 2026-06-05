
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:advisor
    /// </summary>
    public enum OutputItemsVariant9Type
    {
        /// <summary>
        /// openrouter:advisor
        /// </summary>
        Openrouter_advisor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant9Type value)
        {
            return value switch
            {
                OutputItemsVariant9Type.Openrouter_advisor => "openrouter:advisor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:advisor" => OutputItemsVariant9Type.Openrouter_advisor,
                _ => null,
            };
        }
    }
}