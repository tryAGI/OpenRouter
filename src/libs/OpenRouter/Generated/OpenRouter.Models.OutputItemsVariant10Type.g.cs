
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:apply_patch
    /// </summary>
    public enum OutputItemsVariant10Type
    {
        /// <summary>
        /// openrouter:apply_patch
        /// </summary>
        Openrouter_applyPatch,
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
                OutputItemsVariant10Type.Openrouter_applyPatch => "openrouter:apply_patch",
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
                "openrouter:apply_patch" => OutputItemsVariant10Type.Openrouter_applyPatch,
                _ => null,
            };
        }
    }
}