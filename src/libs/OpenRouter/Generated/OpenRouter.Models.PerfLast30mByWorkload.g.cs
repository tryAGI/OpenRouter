
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Endpoint performance over the last 30 minutes, keyed by the kind of request served (e.g. `text_generation`, `image_generation`). Additive to the legacy singular latency and throughput fields; image and video generation report end-to-end latency. Only visible when authenticated with an API key or cookie.
    /// </summary>
    public sealed partial class PerfLast30mByWorkload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decisions")]
        public global::OpenRouter.Decisions? Decisions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::OpenRouter.Embeddings? Embeddings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_generation")]
        public global::OpenRouter.ImageGeneration? ImageGeneration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank")]
        public global::OpenRouter.Rerank? Rerank { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        public global::OpenRouter.Stt? Stt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_generation")]
        public global::OpenRouter.TextGeneration? TextGeneration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::OpenRouter.Tts? Tts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknown")]
        public global::OpenRouter.Unknown? Unknown { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_generation")]
        public global::OpenRouter.VideoGeneration? VideoGeneration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerfLast30mByWorkload" /> class.
        /// </summary>
        /// <param name="decisions"></param>
        /// <param name="embeddings"></param>
        /// <param name="imageGeneration"></param>
        /// <param name="rerank"></param>
        /// <param name="stt"></param>
        /// <param name="textGeneration"></param>
        /// <param name="tts"></param>
        /// <param name="unknown"></param>
        /// <param name="videoGeneration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerfLast30mByWorkload(
            global::OpenRouter.Decisions? decisions,
            global::OpenRouter.Embeddings? embeddings,
            global::OpenRouter.ImageGeneration? imageGeneration,
            global::OpenRouter.Rerank? rerank,
            global::OpenRouter.Stt? stt,
            global::OpenRouter.TextGeneration? textGeneration,
            global::OpenRouter.Tts? tts,
            global::OpenRouter.Unknown? unknown,
            global::OpenRouter.VideoGeneration? videoGeneration)
        {
            this.Decisions = decisions;
            this.Embeddings = embeddings;
            this.ImageGeneration = imageGeneration;
            this.Rerank = rerank;
            this.Stt = stt;
            this.TextGeneration = textGeneration;
            this.Tts = tts;
            this.Unknown = unknown;
            this.VideoGeneration = videoGeneration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerfLast30mByWorkload" /> class.
        /// </summary>
        public PerfLast30mByWorkload()
        {
        }

    }
}