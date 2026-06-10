
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputShellCallOutputItemOutputItemsOutcomeOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputShellCallOutputItemOutputItemsOutcomeOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputShellCallOutputItemOutputItemsOutcomeOneOf1Type value)
        {
            return value switch
            {
                OutputShellCallOutputItemOutputItemsOutcomeOneOf1Type.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputShellCallOutputItemOutputItemsOutcomeOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "timeout" => OutputShellCallOutputItemOutputItemsOutcomeOneOf1Type.Timeout,
                _ => null,
            };
        }
    }
}