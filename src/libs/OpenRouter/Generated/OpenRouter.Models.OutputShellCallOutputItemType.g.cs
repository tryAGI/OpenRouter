
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputShellCallOutputItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ShellCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputShellCallOutputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputShellCallOutputItemType value)
        {
            return value switch
            {
                OutputShellCallOutputItemType.ShellCallOutput => "shell_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputShellCallOutputItemType? ToEnum(string value)
        {
            return value switch
            {
                "shell_call_output" => OutputShellCallOutputItemType.ShellCallOutput,
                _ => null,
            };
        }
    }
}