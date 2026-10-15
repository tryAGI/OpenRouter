
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ArmorSafeguardResultType
    {
        /// <summary>
        ///
        /// </summary>
        DangerousToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArmorSafeguardResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArmorSafeguardResultType value)
        {
            return value switch
            {
                ArmorSafeguardResultType.DangerousToolUse => "dangerous_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArmorSafeguardResultType? ToEnum(string value)
        {
            return value switch
            {
                "dangerous_tool_use" => ArmorSafeguardResultType.DangerousToolUse,
                _ => null,
            };
        }
    }
}