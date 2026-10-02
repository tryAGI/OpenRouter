
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseInputsVariant2ItemPhaseVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Commentary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsVariant2ItemPhaseVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsVariant2ItemPhaseVariant1 value)
        {
            return value switch
            {
                BaseInputsVariant2ItemPhaseVariant1.Commentary => "commentary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsVariant2ItemPhaseVariant1? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => BaseInputsVariant2ItemPhaseVariant1.Commentary,
                _ => null,
            };
        }
    }
}