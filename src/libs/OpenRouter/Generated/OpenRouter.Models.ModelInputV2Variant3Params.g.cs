
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelInputV2Variant3Params
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        public global::OpenRouter.ModelInputV2Variant3ParamsFormats? Formats { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_content_size_bytes")]
        public global::OpenRouter.ModelInputV2Variant3ParamsMaxContentSizeBytes? MaxContentSizeBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_seconds")]
        public global::OpenRouter.ModelInputV2Variant3ParamsMaxDurationSeconds? MaxDurationSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::OpenRouter.ModelInputV2Variant3ParamsSources? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant3Params" /> class.
        /// </summary>
        /// <param name="formats"></param>
        /// <param name="maxContentSizeBytes"></param>
        /// <param name="maxDurationSeconds"></param>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInputV2Variant3Params(
            global::OpenRouter.ModelInputV2Variant3ParamsFormats? formats,
            global::OpenRouter.ModelInputV2Variant3ParamsMaxContentSizeBytes? maxContentSizeBytes,
            global::OpenRouter.ModelInputV2Variant3ParamsMaxDurationSeconds? maxDurationSeconds,
            global::OpenRouter.ModelInputV2Variant3ParamsSources? sources)
        {
            this.Formats = formats;
            this.MaxContentSizeBytes = maxContentSizeBytes;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant3Params" /> class.
        /// </summary>
        public ModelInputV2Variant3Params()
        {
        }

    }
}