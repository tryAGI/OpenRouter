
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ORAnthropicBashToolResultType
    {
        /// <summary>
        ///
        /// </summary>
        OpenrouterBashToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicBashToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicBashToolResultType value)
        {
            return value switch
            {
                ORAnthropicBashToolResultType.OpenrouterBashToolResult => "openrouter_bash_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicBashToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter_bash_tool_result" => ORAnthropicBashToolResultType.OpenrouterBashToolResult,
                _ => null,
            };
        }
    }
}