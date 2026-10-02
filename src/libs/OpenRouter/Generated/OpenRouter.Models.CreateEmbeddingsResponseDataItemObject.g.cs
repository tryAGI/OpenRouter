
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateEmbeddingsResponseDataItemObject
    {
        /// <summary>
        ///
        /// </summary>
        Embedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingsResponseDataItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingsResponseDataItemObject value)
        {
            return value switch
            {
                CreateEmbeddingsResponseDataItemObject.Embedding => "embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingsResponseDataItemObject? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => CreateEmbeddingsResponseDataItemObject.Embedding,
                _ => null,
            };
        }
    }
}