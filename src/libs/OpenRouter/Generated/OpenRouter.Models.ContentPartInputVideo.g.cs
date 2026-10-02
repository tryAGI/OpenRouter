
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"input_video":{"data":"data:video/mp4;base64,AAAAGGZ0eXBtcDQyAAAAAGlzb21tcDQy...","format":"mp4"},"type":"input_video"}
    /// </summary>
    public sealed partial class ContentPartInputVideo
    {
        /// <summary>
        /// Example: {"data":"data:audio/wav;base64,UklGRiQAAABXQVZFZm10IBAAAAA...","format":"wav"}
        /// </summary>
        /// <example>{"data":"data:audio/wav;base64,UklGRiQAAABXQVZFZm10IBAAAAA...","format":"wav"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MultimodalMedia InputVideo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContentPartInputVideoTypeJsonConverter))]
        public global::OpenRouter.ContentPartInputVideoType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPartInputVideo" /> class.
        /// </summary>
        /// <param name="inputVideo">
        /// Example: {"data":"data:audio/wav;base64,UklGRiQAAABXQVZFZm10IBAAAAA...","format":"wav"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentPartInputVideo(
            global::OpenRouter.MultimodalMedia inputVideo,
            global::OpenRouter.ContentPartInputVideoType type)
        {
            this.InputVideo = inputVideo ?? throw new global::System.ArgumentNullException(nameof(inputVideo));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPartInputVideo" /> class.
        /// </summary>
        public ContentPartInputVideo()
        {
        }

    }
}