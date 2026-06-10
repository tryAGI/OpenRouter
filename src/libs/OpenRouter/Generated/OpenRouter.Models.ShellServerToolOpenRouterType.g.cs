
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ShellServerToolOpenRouterType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_shell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellServerToolOpenRouterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellServerToolOpenRouterType value)
        {
            return value switch
            {
                ShellServerToolOpenRouterType.Openrouter_shell => "openrouter:shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellServerToolOpenRouterType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:shell" => ShellServerToolOpenRouterType.Openrouter_shell,
                _ => null,
            };
        }
    }
}