
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalShellCallOutputItemType
    {
        /// <summary>
        /// 
        /// </summary>
        LocalShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalShellCallOutputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellCallOutputItemType value)
        {
            return value switch
            {
                LocalShellCallOutputItemType.LocalShellCallOutput => "local_shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellCallOutputItemType? ToEnum(string value)
        {
            return value switch
            {
                "local_shell_call_output" => LocalShellCallOutputItemType.LocalShellCallOutput,
                _ => null,
            };
        }
    }
}