
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelInputV2Variant2Params
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail_levels")]
        public global::OpenRouter.ModelInputV2Variant2ParamsDetailLevels? DetailLevels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        public global::OpenRouter.ModelInputV2Variant2ParamsFormats? Formats { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_content_size_bytes")]
        public global::OpenRouter.ModelInputV2Variant2ParamsMaxContentSizeBytes? MaxContentSizeBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::OpenRouter.ModelInputV2Variant2ParamsReferences? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::OpenRouter.ModelInputV2Variant2ParamsRole? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::OpenRouter.ModelInputV2Variant2ParamsSources? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant2Params" /> class.
        /// </summary>
        /// <param name="detailLevels"></param>
        /// <param name="formats"></param>
        /// <param name="maxContentSizeBytes"></param>
        /// <param name="references"></param>
        /// <param name="role"></param>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInputV2Variant2Params(
            global::OpenRouter.ModelInputV2Variant2ParamsDetailLevels? detailLevels,
            global::OpenRouter.ModelInputV2Variant2ParamsFormats? formats,
            global::OpenRouter.ModelInputV2Variant2ParamsMaxContentSizeBytes? maxContentSizeBytes,
            global::OpenRouter.ModelInputV2Variant2ParamsReferences? references,
            global::OpenRouter.ModelInputV2Variant2ParamsRole? role,
            global::OpenRouter.ModelInputV2Variant2ParamsSources? sources)
        {
            this.DetailLevels = detailLevels;
            this.Formats = formats;
            this.MaxContentSizeBytes = maxContentSizeBytes;
            this.References = references;
            this.Role = role;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant2Params" /> class.
        /// </summary>
        public ModelInputV2Variant2Params()
        {
        }

    }
}