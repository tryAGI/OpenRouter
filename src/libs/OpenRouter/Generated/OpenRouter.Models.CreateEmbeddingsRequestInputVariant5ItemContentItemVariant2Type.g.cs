
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2Type value)
        {
            return value switch
            {
                CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}