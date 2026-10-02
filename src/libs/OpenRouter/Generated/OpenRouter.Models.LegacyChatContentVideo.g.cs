
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Video input content part (legacy format - deprecated)<br/>
    /// Example: {"type":"input_video","video_url":{"url":"https://example.com/video.mp4"}}
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class LegacyChatContentVideo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.LegacyChatContentVideoTypeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::OpenRouter.LegacyChatContentVideoType Type { get; set; }

        /// <summary>
        /// Video input object<br/>
        /// Example: {"url":"https://example.com/video.mp4"}
        /// </summary>
        /// <example>{"url":"https://example.com/video.mp4"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::OpenRouter.LegacyChatContentVideoInput VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyChatContentVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// Video input object<br/>
        /// Example: {"url":"https://example.com/video.mp4"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyChatContentVideo(
            global::OpenRouter.LegacyChatContentVideoInput videoUrl,
            global::OpenRouter.LegacyChatContentVideoType type)
        {
            this.Type = type;
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyChatContentVideo" /> class.
        /// </summary>
        public LegacyChatContentVideo()
        {
        }

    }
}