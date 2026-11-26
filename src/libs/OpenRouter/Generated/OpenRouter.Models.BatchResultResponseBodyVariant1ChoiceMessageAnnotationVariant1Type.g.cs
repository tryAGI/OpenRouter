
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1Type value)
        {
            return value switch
            {
                BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1Type.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "file" => BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1Type.File,
                _ => null,
            };
        }
    }
}