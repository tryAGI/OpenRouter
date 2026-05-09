
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:file_search
    /// </summary>
    public enum OutputItemsVariant14Type
    {
        /// <summary>
        /// openrouter:file_search
        /// </summary>
        Openrouter_fileSearch,
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
                OutputItemsVariant14Type.Openrouter_fileSearch => "openrouter:file_search",
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
                "openrouter:file_search" => OutputItemsVariant14Type.Openrouter_fileSearch,
                _ => null,
            };
        }
    }
}