
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Video input content part<br/>
    /// Example: {"type":"video_url","video_url":{"url":"https://example.com/video.mp4"}}
    /// </summary>
    public sealed partial class ChatContentVideo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatContentVideoTypeJsonConverter))]
        public global::OpenRouter.ChatContentVideoType Type { get; set; }

        /// <summary>
        /// Video input object<br/>
        /// Example: {"url":"https://example.com/video.mp4"}
        /// </summary>
        /// <example>{"url":"https://example.com/video.mp4"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatContentVideoInput VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// Video input object<br/>
        /// Example: {"url":"https://example.com/video.mp4"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContentVideo(
            global::OpenRouter.ChatContentVideoInput videoUrl,
            global::OpenRouter.ChatContentVideoType type)
        {
            this.Type = type;
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentVideo" /> class.
        /// </summary>
        public ChatContentVideo()
        {
        }

    }
}