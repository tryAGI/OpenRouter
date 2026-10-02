
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Video input content item<br/>
    /// Example: {"type":"input_video","video_url":"https://example.com/video.mp4"}
    /// </summary>
    public sealed partial class InputVideo
    {
        /// <summary>
        /// Video processing mode. `agentic` enables agentic video processing and `static` forces fixed-rate frame sampling on providers that support it (currently Google Gemini).<br/>
        /// Example: agentic
        /// </summary>
        /// <example>agentic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputVideoProcessingJsonConverter))]
        public global::OpenRouter.InputVideoProcessing? Processing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputVideoTypeJsonConverter))]
        public global::OpenRouter.InputVideoType Type { get; set; }

        /// <summary>
        /// A base64 data URL or remote URL that resolves to a video file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// A base64 data URL or remote URL that resolves to a video file
        /// </param>
        /// <param name="processing">
        /// Video processing mode. `agentic` enables agentic video processing and `static` forces fixed-rate frame sampling on providers that support it (currently Google Gemini).<br/>
        /// Example: agentic
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputVideo(
            string videoUrl,
            global::OpenRouter.InputVideoProcessing? processing,
            global::OpenRouter.InputVideoType type)
        {
            this.Processing = processing;
            this.Type = type;
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputVideo" /> class.
        /// </summary>
        public InputVideo()
        {
        }

    }
}