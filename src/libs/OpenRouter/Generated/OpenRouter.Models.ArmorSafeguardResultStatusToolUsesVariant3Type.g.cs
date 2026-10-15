
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ArmorSafeguardResultStatusToolUsesVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArmorSafeguardResultStatusToolUsesVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArmorSafeguardResultStatusToolUsesVariant3Type value)
        {
            return value switch
            {
                ArmorSafeguardResultStatusToolUsesVariant3Type.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArmorSafeguardResultStatusToolUsesVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "unavailable" => ArmorSafeguardResultStatusToolUsesVariant3Type.Unavailable,
                _ => null,
            };
        }
    }
}