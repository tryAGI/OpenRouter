
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:datetime
    /// </summary>
    public enum OutputItemsVariant11Type
    {
        /// <summary>
        /// openrouter:datetime
        /// </summary>
        Openrouter_datetime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant11Type value)
        {
            return value switch
            {
                OutputItemsVariant11Type.Openrouter_datetime => "openrouter:datetime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:datetime" => OutputItemsVariant11Type.Openrouter_datetime,
                _ => null,
            };
        }
    }
}