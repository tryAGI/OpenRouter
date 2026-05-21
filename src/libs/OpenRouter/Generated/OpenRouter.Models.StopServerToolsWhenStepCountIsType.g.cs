
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum StopServerToolsWhenStepCountIsType
    {
        /// <summary>
        /// 
        /// </summary>
        StepCountIs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopServerToolsWhenStepCountIsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopServerToolsWhenStepCountIsType value)
        {
            return value switch
            {
                StopServerToolsWhenStepCountIsType.StepCountIs => "step_count_is",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopServerToolsWhenStepCountIsType? ToEnum(string value)
        {
            return value switch
            {
                "step_count_is" => StopServerToolsWhenStepCountIsType.StepCountIs,
                _ => null,
            };
        }
    }
}