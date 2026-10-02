
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum EasyInputMessagePhaseVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Commentary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessagePhaseVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessagePhaseVariant1 value)
        {
            return value switch
            {
                EasyInputMessagePhaseVariant1.Commentary => "commentary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessagePhaseVariant1? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => EasyInputMessagePhaseVariant1.Commentary,
                _ => null,
            };
        }
    }
}