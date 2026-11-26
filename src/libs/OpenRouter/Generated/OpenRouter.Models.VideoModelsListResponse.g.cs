
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"allowed_passthrough_parameters":["personGeneration","aspectRatio","negativePrompt","conditioningScale","enhancePrompt"],"canonical_slug":"google/veo-3.1-20260320","created":1774277148,"creativity":null,"description":"Google video generation model","generate_audio":true,"hugging_face_id":null,"id":"google/veo-3.1","name":"Google: Veo 3.1","pricing_skus":{"duration_seconds_with_audio":"0.40","duration_seconds_with_audio_4k":"0.60","duration_seconds_without_audio":"0.20","duration_seconds_without_audio_4k":"0.40"},"seed":true,"supported_aspect_ratios":["16:9","9:16"],"supported_durations":[4,6,8],"supported_frame_images":["first_frame","last_frame"],"supported_resolutions":["720p","1080p","4K"],"supported_sizes":["1280x720","1080x1920","1920x1080","720x1280","3840x2160","2160x3840"],"upscale_factor":null}]}
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