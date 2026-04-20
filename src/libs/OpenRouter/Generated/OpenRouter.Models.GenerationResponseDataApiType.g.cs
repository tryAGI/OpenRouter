
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Type of API used for the generation
    /// </summary>
    public enum GenerationResponseDataApiType
    {
        /// <summary>
        /// 
        /// </summary>
        Completions,
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        Tts,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataApiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataApiType value)
        {
            return value switch
            {
                GenerationResponseDataApiType.Completions => "completions",
                GenerationResponseDataApiType.Embeddings => "embeddings",
                GenerationResponseDataApiType.Rerank => "rerank",
                GenerationResponseDataApiType.Tts => "tts",
                GenerationResponseDataApiType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataApiType? ToEnum(string value)
        {
            return value switch
            {
                "completions" => GenerationResponseDataApiType.Completions,
                "embeddings" => GenerationResponseDataApiType.Embeddings,
                "rerank" => GenerationResponseDataApiType.Rerank,
                "tts" => GenerationResponseDataApiType.Tts,
                "video" => GenerationResponseDataApiType.Video,
                _ => null,
            };
        }
    }
}