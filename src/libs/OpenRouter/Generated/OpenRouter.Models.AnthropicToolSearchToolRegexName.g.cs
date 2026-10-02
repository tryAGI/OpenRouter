
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolSearchToolRegexName
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchToolRegex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolSearchToolRegexNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolSearchToolRegexName value)
        {
            return value switch
            {
                AnthropicToolSearchToolRegexName.ToolSearchToolRegex => "tool_search_tool_regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolSearchToolRegexName? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_regex" => AnthropicToolSearchToolRegexName.ToolSearchToolRegex,
                _ => null,
            };
        }
    }
}