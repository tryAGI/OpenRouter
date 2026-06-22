
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageOutputModality
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        Speech,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Transcription,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageOutputModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageOutputModality value)
        {
            return value switch
            {
                ImageOutputModality.Audio => "audio",
                ImageOutputModality.Embeddings => "embeddings",
                ImageOutputModality.Image => "image",
                ImageOutputModality.Rerank => "rerank",
                ImageOutputModality.Speech => "speech",
                ImageOutputModality.Text => "text",
                ImageOutputModality.Transcription => "transcription",
                ImageOutputModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageOutputModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ImageOutputModality.Audio,
                "embeddings" => ImageOutputModality.Embeddings,
                "image" => ImageOutputModality.Image,
                "rerank" => ImageOutputModality.Rerank,
                "speech" => ImageOutputModality.Speech,
                "text" => ImageOutputModality.Text,
                "transcription" => ImageOutputModality.Transcription,
                "video" => ImageOutputModality.Video,
                _ => null,
            };
        }
    }
}