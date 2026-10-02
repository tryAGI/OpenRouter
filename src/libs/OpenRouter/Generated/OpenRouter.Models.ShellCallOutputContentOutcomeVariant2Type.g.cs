
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ShellCallOutputContentOutcomeVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellCallOutputContentOutcomeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellCallOutputContentOutcomeVariant2Type value)
        {
            return value switch
            {
                ShellCallOutputContentOutcomeVariant2Type.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellCallOutputContentOutcomeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "timeout" => ShellCallOutputContentOutcomeVariant2Type.Timeout,
                _ => null,
            };
        }
    }
}