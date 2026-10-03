
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelOutputV2Variant7Type
    {
        /// <summary>
        ///
        /// </summary>
        Rerank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOutputV2Variant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOutputV2Variant7Type value)
        {
            return value switch
            {
                ModelOutputV2Variant7Type.Rerank => "rerank",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOutputV2Variant7Type? ToEnum(string value)
        {
            return value switch
            {
                "rerank" => ModelOutputV2Variant7Type.Rerank,
                _ => null,
            };
        }
    }
}