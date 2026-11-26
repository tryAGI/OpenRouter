
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchResultResponseBodyVariant4DataItemObject
    {
        /// <summary>
        ///
        /// </summary>
        Embedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant4DataItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant4DataItemObject value)
        {
            return value switch
            {
                BatchResultResponseBodyVariant4DataItemObject.Embedding => "embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant4DataItemObject? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => BatchResultResponseBodyVariant4DataItemObject.Embedding,
                _ => null,
            };
        }
    }
}