
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputMemoryServerToolItemAction
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMemoryServerToolItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMemoryServerToolItemAction value)
        {
            return value switch
            {
                OutputMemoryServerToolItemAction.Delete => "delete",
                OutputMemoryServerToolItemAction.Read => "read",
                OutputMemoryServerToolItemAction.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMemoryServerToolItemAction? ToEnum(string value)
        {
            return value switch
            {
                "delete" => OutputMemoryServerToolItemAction.Delete,
                "read" => OutputMemoryServerToolItemAction.Read,
                "write" => OutputMemoryServerToolItemAction.Write,
                _ => null,
            };
        }
    }
}