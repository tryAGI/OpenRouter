
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Video input content item
    /// </summary>
    public sealed partial class InputVideo
    {
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
        /// <param name="type"></param>
        /// <param name="videoUrl">
        /// A base64 data URL or remote URL that resolves to a video file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputVideo(
            string videoUrl,
            global::OpenRouter.InputVideoType type)
        {
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputVideo" /> class.
        /// </summary>
        public InputVideo()
        {
        }
    }
}