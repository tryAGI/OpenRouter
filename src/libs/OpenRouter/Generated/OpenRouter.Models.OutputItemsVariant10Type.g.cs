
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:bash
    /// </summary>
    public enum OutputItemsVariant10Type
    {
        /// <summary>
        /// openrouter:bash
        /// </summary>
        Openrouter_bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant10Type value)
        {
            return value switch
            {
                OutputItemsVariant10Type.Openrouter_bash => "openrouter:bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:bash" => OutputItemsVariant10Type.Openrouter_bash,
                _ => null,
            };
        }
    }
}