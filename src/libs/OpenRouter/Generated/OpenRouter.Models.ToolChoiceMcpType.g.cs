
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolChoiceMcpType
    {
        /// <summary>
        ///
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceMcpTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceMcpType value)
        {
            return value switch
            {
                ToolChoiceMcpType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceMcpType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => ToolChoiceMcpType.Mcp,
                _ => null,
            };
        }
    }
}