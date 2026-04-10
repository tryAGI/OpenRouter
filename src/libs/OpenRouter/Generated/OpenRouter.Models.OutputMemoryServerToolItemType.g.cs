
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputMemoryServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_memory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMemoryServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMemoryServerToolItemType value)
        {
            return value switch
            {
                OutputMemoryServerToolItemType.Openrouter_memory => "openrouter:memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMemoryServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:memory" => OutputMemoryServerToolItemType.Openrouter_memory,
                _ => null,
            };
        }
    }
}