
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputMessagePhaseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        FinalAnswer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessagePhaseVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessagePhaseVariant2 value)
        {
            return value switch
            {
                OutputMessagePhaseVariant2.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessagePhaseVariant2? ToEnum(string value)
        {
            return value switch
            {
                "final_answer" => OutputMessagePhaseVariant2.FinalAnswer,
                _ => null,
            };
        }
    }
}