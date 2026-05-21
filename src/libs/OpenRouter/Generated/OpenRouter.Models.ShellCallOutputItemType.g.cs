
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ShellCallOutputItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellCallOutputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellCallOutputItemType value)
        {
            return value switch
            {
                ShellCallOutputItemType.ShellCallOutput => "shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellCallOutputItemType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call_output" => ShellCallOutputItemType.ShellCallOutput,
                _ => null,
            };
        }
    }
}