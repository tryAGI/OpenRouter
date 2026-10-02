
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The event type
    /// </summary>
    public enum ImageGenTextChunkEventType
    {
        /// <summary>
        ///
        /// </summary>
        ImageGenerationTextChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenTextChunkEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenTextChunkEventType value)
        {
            return value switch
            {
                ImageGenTextChunkEventType.ImageGenerationTextChunk => "image_generation.text_chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenTextChunkEventType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation.text_chunk" => ImageGenTextChunkEventType.ImageGenerationTextChunk,
                _ => null,
            };
        }
    }
}