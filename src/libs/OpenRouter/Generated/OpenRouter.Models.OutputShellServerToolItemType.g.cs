
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputShellServerToolItemType
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter_shell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputShellServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputShellServerToolItemType value)
        {
            return value switch
            {
                OutputShellServerToolItemType.Openrouter_shell => "openrouter:shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputShellServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:shell" => OutputShellServerToolItemType.Openrouter_shell,
                _ => null,
            };
        }
    }
}