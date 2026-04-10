
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputToolSearchServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_toolSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputToolSearchServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputToolSearchServerToolItemType value)
        {
            return value switch
            {
                OutputToolSearchServerToolItemType.Openrouter_toolSearch => "openrouter:tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputToolSearchServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:tool_search" => OutputToolSearchServerToolItemType.Openrouter_toolSearch,
                _ => null,
            };
        }
    }
}