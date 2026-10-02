
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesShellToolResultBlockType
    {
        /// <summary>
        ///
        /// </summary>
        OpenrouterShellToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesShellToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesShellToolResultBlockType value)
        {
            return value switch
            {
                MessagesShellToolResultBlockType.OpenrouterShellToolResult => "openrouter_shell_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesShellToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter_shell_tool_result" => MessagesShellToolResultBlockType.OpenrouterShellToolResult,
                _ => null,
            };
        }
    }
}