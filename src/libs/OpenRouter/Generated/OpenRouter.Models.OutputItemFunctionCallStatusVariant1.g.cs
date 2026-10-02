
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemFunctionCallStatusVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemFunctionCallStatusVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemFunctionCallStatusVariant1 value)
        {
            return value switch
            {
                OutputItemFunctionCallStatusVariant1.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemFunctionCallStatusVariant1? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputItemFunctionCallStatusVariant1.Completed,
                _ => null,
            };
        }
    }
}