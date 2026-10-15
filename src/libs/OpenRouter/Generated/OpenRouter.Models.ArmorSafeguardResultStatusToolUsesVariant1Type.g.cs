
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ArmorSafeguardResultStatusToolUsesVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Evaluated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArmorSafeguardResultStatusToolUsesVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArmorSafeguardResultStatusToolUsesVariant1Type value)
        {
            return value switch
            {
                ArmorSafeguardResultStatusToolUsesVariant1Type.Evaluated => "evaluated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArmorSafeguardResultStatusToolUsesVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "evaluated" => ArmorSafeguardResultStatusToolUsesVariant1Type.Evaluated,
                _ => null,
            };
        }
    }
}