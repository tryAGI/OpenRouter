
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchObjectResultResponseBodyVariant4DataItemObject
    {
        /// <summary>
        ///
        /// </summary>
        Embedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectResultResponseBodyVariant4DataItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectResultResponseBodyVariant4DataItemObject value)
        {
            return value switch
            {
                BatchObjectResultResponseBodyVariant4DataItemObject.Embedding => "embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectResultResponseBodyVariant4DataItemObject? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => BatchObjectResultResponseBodyVariant4DataItemObject.Embedding,
                _ => null,
            };
        }
    }
}