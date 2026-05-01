
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputMessageItemPhase1
    {
        /// <summary>
        /// 
        /// </summary>
        FinalAnswer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessageItemPhase1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessageItemPhase1 value)
        {
            return value switch
            {
                OutputMessageItemPhase1.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessageItemPhase1? ToEnum(string value)
        {
            return value switch
            {
                "final_answer" => OutputMessageItemPhase1.FinalAnswer,
                _ => null,
            };
        }
    }
}