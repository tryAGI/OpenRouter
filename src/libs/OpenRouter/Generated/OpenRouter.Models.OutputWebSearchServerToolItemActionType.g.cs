
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputWebSearchServerToolItemActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputWebSearchServerToolItemActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputWebSearchServerToolItemActionType value)
        {
            return value switch
            {
                OutputWebSearchServerToolItemActionType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputWebSearchServerToolItemActionType? ToEnum(string value)
        {
            return value switch
            {
                "search" => OutputWebSearchServerToolItemActionType.Search,
                _ => null,
            };
        }
    }
}