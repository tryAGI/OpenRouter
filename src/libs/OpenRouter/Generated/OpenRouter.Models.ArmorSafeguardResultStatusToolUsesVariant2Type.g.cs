
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ArmorSafeguardResultStatusToolUsesVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArmorSafeguardResultStatusToolUsesVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArmorSafeguardResultStatusToolUsesVariant2Type value)
        {
            return value switch
            {
                ArmorSafeguardResultStatusToolUsesVariant2Type.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArmorSafeguardResultStatusToolUsesVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "skipped" => ArmorSafeguardResultStatusToolUsesVariant2Type.Skipped,
                _ => null,
            };
        }
    }
}