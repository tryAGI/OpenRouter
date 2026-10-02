
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputMessageStatusVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessageStatusVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessageStatusVariant2 value)
        {
            return value switch
            {
                OutputMessageStatusVariant2.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessageStatusVariant2? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => OutputMessageStatusVariant2.Incomplete,
                _ => null,
            };
        }
    }
}