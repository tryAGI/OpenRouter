
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelOutputV2Variant6Type
    {
        /// <summary>
        ///
        /// </summary>
        Embeddings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOutputV2Variant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOutputV2Variant6Type value)
        {
            return value switch
            {
                ModelOutputV2Variant6Type.Embeddings => "embeddings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOutputV2Variant6Type? ToEnum(string value)
        {
            return value switch
            {
                "embeddings" => ModelOutputV2Variant6Type.Embeddings,
                _ => null,
            };
        }
    }
}