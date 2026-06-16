
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputShellCallOutputItemOutputItemsOutcomeOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Exit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputShellCallOutputItemOutputItemsOutcomeOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputShellCallOutputItemOutputItemsOutcomeOneOf0Type value)
        {
            return value switch
            {
                OutputShellCallOutputItemOutputItemsOutcomeOneOf0Type.Exit => "exit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputShellCallOutputItemOutputItemsOutcomeOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "exit" => OutputShellCallOutputItemOutputItemsOutcomeOneOf0Type.Exit,
                _ => null,
            };
        }
    }
}