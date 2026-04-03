
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolChoiceAllowedMode1
    {
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceAllowedMode1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceAllowedMode1 value)
        {
            return value switch
            {
                ToolChoiceAllowedMode1.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceAllowedMode1? ToEnum(string value)
        {
            return value switch
            {
                "required" => ToolChoiceAllowedMode1.Required,
                _ => null,
            };
        }
    }
}