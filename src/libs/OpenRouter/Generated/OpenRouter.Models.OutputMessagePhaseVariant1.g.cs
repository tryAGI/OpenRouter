
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputMessagePhaseVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Commentary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessagePhaseVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessagePhaseVariant1 value)
        {
            return value switch
            {
                OutputMessagePhaseVariant1.Commentary => "commentary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessagePhaseVariant1? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => OutputMessagePhaseVariant1.Commentary,
                _ => null,
            };
        }
    }
}