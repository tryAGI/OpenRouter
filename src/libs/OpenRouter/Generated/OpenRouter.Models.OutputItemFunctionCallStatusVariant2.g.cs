
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemFunctionCallStatusVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemFunctionCallStatusVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemFunctionCallStatusVariant2 value)
        {
            return value switch
            {
                OutputItemFunctionCallStatusVariant2.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemFunctionCallStatusVariant2? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => OutputItemFunctionCallStatusVariant2.Incomplete,
                _ => null,
            };
        }
    }
}