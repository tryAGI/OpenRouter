
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputMcpServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMcpServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMcpServerToolItemType value)
        {
            return value switch
            {
                OutputMcpServerToolItemType.Openrouter_mcp => "openrouter:mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMcpServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:mcp" => OutputMcpServerToolItemType.Openrouter_mcp,
                _ => null,
            };
        }
    }
}