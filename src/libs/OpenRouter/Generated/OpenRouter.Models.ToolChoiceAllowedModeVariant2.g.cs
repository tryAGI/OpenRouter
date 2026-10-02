
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolChoiceAllowedModeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceAllowedModeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceAllowedModeVariant2 value)
        {
            return value switch
            {
                ToolChoiceAllowedModeVariant2.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceAllowedModeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "required" => ToolChoiceAllowedModeVariant2.Required,
                _ => null,
            };
        }
    }
}