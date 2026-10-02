
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ORAnthropicShellToolResultType
    {
        /// <summary>
        ///
        /// </summary>
        OpenrouterShellToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicShellToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicShellToolResultType value)
        {
            return value switch
            {
                ORAnthropicShellToolResultType.OpenrouterShellToolResult => "openrouter_shell_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicShellToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter_shell_tool_result" => ORAnthropicShellToolResultType.OpenrouterShellToolResult,
                _ => null,
            };
        }
    }
}