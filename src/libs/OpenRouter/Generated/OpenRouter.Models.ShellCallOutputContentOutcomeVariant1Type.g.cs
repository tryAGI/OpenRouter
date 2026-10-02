
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ShellCallOutputContentOutcomeVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellCallOutputContentOutcomeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellCallOutputContentOutcomeVariant1Type value)
        {
            return value switch
            {
                ShellCallOutputContentOutcomeVariant1Type.Exit => "exit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellCallOutputContentOutcomeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "exit" => ShellCallOutputContentOutcomeVariant1Type.Exit,
                _ => null,
            };
        }
    }
}