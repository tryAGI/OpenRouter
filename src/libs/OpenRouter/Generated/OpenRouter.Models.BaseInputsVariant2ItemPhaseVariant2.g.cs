
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseInputsVariant2ItemPhaseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        FinalAnswer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseInputsVariant2ItemPhaseVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseInputsVariant2ItemPhaseVariant2 value)
        {
            return value switch
            {
                BaseInputsVariant2ItemPhaseVariant2.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseInputsVariant2ItemPhaseVariant2? ToEnum(string value)
        {
            return value switch
            {
                "final_answer" => BaseInputsVariant2ItemPhaseVariant2.FinalAnswer,
                _ => null,
            };
        }
    }
}