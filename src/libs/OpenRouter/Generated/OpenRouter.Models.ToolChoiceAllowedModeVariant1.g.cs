
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolChoiceAllowedModeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceAllowedModeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceAllowedModeVariant1 value)
        {
            return value switch
            {
                ToolChoiceAllowedModeVariant1.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceAllowedModeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ToolChoiceAllowedModeVariant1.Auto,
                _ => null,
            };
        }
    }
}