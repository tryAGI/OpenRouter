
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:files
    /// </summary>
    public enum OutputItemsVariant17Type
    {
        /// <summary>
        /// openrouter:files
        /// </summary>
        Openrouter_files,
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
                OutputItemsVariant17Type.Openrouter_files => "openrouter:files",
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
                "openrouter:files" => OutputItemsVariant17Type.Openrouter_files,
                _ => null,
            };
        }
    }
}