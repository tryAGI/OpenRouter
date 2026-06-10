
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum BashServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashServerToolType value)
        {
            return value switch
            {
                BashServerToolType.Openrouter_bash => "openrouter:bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:bash" => BashServerToolType.Openrouter_bash,
                _ => null,
            };
        }
    }
}