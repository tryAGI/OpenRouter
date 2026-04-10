
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputBashServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputBashServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputBashServerToolItemType value)
        {
            return value switch
            {
                OutputBashServerToolItemType.Openrouter_bash => "openrouter:bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputBashServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:bash" => OutputBashServerToolItemType.Openrouter_bash,
                _ => null,
            };
        }
    }
}