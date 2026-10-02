
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemFunctionCallStatusVariant3
    {
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemFunctionCallStatusVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemFunctionCallStatusVariant3 value)
        {
            return value switch
            {
                OutputItemFunctionCallStatusVariant3.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemFunctionCallStatusVariant3? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => OutputItemFunctionCallStatusVariant3.InProgress,
                _ => null,
            };
        }
    }
}