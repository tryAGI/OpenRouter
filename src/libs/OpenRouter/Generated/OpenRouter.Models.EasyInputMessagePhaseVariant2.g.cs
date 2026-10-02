
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum EasyInputMessagePhaseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        FinalAnswer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessagePhaseVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessagePhaseVariant2 value)
        {
            return value switch
            {
                EasyInputMessagePhaseVariant2.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessagePhaseVariant2? ToEnum(string value)
        {
            return value switch
            {
                "final_answer" => EasyInputMessagePhaseVariant2.FinalAnswer,
                _ => null,
            };
        }
    }
}