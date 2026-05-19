
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum StopServerToolsWhenFinishReasonIsType
    {
        /// <summary>
        /// 
        /// </summary>
        FinishReasonIs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopServerToolsWhenFinishReasonIsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopServerToolsWhenFinishReasonIsType value)
        {
            return value switch
            {
                StopServerToolsWhenFinishReasonIsType.FinishReasonIs => "finish_reason_is",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopServerToolsWhenFinishReasonIsType? ToEnum(string value)
        {
            return value switch
            {
                "finish_reason_is" => StopServerToolsWhenFinishReasonIsType.FinishReasonIs,
                _ => null,
            };
        }
    }
}