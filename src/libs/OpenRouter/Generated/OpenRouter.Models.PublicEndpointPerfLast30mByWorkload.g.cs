
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Endpoint performance over the last 30 minutes, keyed by the kind of request served (e.g. `text_generation`, `image_generation`). Additive to the legacy singular latency and throughput fields; image and video generation report end-to-end latency. Only visible when authenticated with an API key or cookie.
    /// </summary>
    public sealed partial class PublicEndpointPerfLast30mByWorkload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decisions")]
        public global::OpenRouter.PublicEndpointPerfLast30mByWorkloadDecisions? Decisions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::OpenRouter.PublicEndpointPerfLast30mByWorkloadEmbeddings? Embeddings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_generation")]
        public global::OpenRouter.PublicEndpointPerfLast30mByWorkloadImageGeneration? ImageGeneration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank")]
        public global::OpenRouter.PublicEndpointPerfLast30mByWorkloadRerank? Rerank { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        public global::OpenRouter.PublicEndpointPerfLast30mByWorkloadStt? Stt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_generation")]
        public global::OpenRouter.PublicEndpointPerfLast30mByWorkloadTextGeneration? TextGeneration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::OpenRouter.PublicEndpointPerfLast30mByWorkloadTts? Tts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknown")]
        public global::OpenRouter.PublicEndpointPerfLast30mByWorkloadUnknown? Unknown { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_generation")]
        public global::OpenRouter.PublicEndpointPerfLast30mByWorkloadVideoGeneration? VideoGeneration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpointPerfLast30mByWorkload" /> class.
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
        public PublicEndpointPerfLast30mByWorkload(
            global::OpenRouter.PublicEndpointPerfLast30mByWorkloadDecisions? decisions,
            global::OpenRouter.PublicEndpointPerfLast30mByWorkloadEmbeddings? embeddings,
            global::OpenRouter.PublicEndpointPerfLast30mByWorkloadImageGeneration? imageGeneration,
            global::OpenRouter.PublicEndpointPerfLast30mByWorkloadRerank? rerank,
            global::OpenRouter.PublicEndpointPerfLast30mByWorkloadStt? stt,
            global::OpenRouter.PublicEndpointPerfLast30mByWorkloadTextGeneration? textGeneration,
            global::OpenRouter.PublicEndpointPerfLast30mByWorkloadTts? tts,
            global::OpenRouter.PublicEndpointPerfLast30mByWorkloadUnknown? unknown,
            global::OpenRouter.PublicEndpointPerfLast30mByWorkloadVideoGeneration? videoGeneration)
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
        /// Initializes a new instance of the <see cref="PublicEndpointPerfLast30mByWorkload" /> class.
        /// </summary>
        public PublicEndpointPerfLast30mByWorkload()
        {
        }

    }
}