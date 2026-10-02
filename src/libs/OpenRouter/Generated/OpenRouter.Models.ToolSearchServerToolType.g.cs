
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolSearchServerToolType
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter_toolSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchServerToolType value)
        {
            return value switch
            {
                ToolSearchServerToolType.Openrouter_toolSearch => "openrouter:tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:tool_search" => ToolSearchServerToolType.Openrouter_toolSearch,
                _ => null,
            };
        }
    }
}