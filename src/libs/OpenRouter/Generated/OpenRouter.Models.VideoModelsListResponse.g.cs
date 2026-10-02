
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"allowed_passthrough_parameters":[],"canonical_slug":"google/veo-3.1","created":1700000000,"description":"Google video generation model","generate_audio":true,"id":"google/veo-3.1","name":"Veo 3.1","pricing_skus":{"generate":"0.50"},"seed":null,"supported_aspect_ratios":["16:9"],"supported_durations":[5,8],"supported_frame_images":["first_frame","last_frame"],"supported_resolutions":["720p"],"supported_sizes":null}]}
    /// </summary>
    public sealed partial class VideoModelsListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VideoModel> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoModelsListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoModelsListResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.VideoModel> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoModelsListResponse" /> class.
        /// </summary>
        public VideoModelsListResponse()
        {
        }

    }
}