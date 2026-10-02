
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputMessageStatusVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessageStatusVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessageStatusVariant1 value)
        {
            return value switch
            {
                OutputMessageStatusVariant1.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessageStatusVariant1? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputMessageStatusVariant1.Completed,
                _ => null,
            };
        }
    }
}