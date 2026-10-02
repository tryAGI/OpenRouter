
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesBashToolResultBlockType
    {
        /// <summary>
        ///
        /// </summary>
        OpenrouterBashToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesBashToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesBashToolResultBlockType value)
        {
            return value switch
            {
                MessagesBashToolResultBlockType.OpenrouterBashToolResult => "openrouter_bash_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesBashToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter_bash_tool_result" => MessagesBashToolResultBlockType.OpenrouterBashToolResult,
                _ => null,
            };
        }
    }
}