
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelInputV2Variant5Params
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        public global::OpenRouter.ModelInputV2Variant5ParamsFormats? Formats { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_content_size_bytes")]
        public global::OpenRouter.ModelInputV2Variant5ParamsMaxContentSizeBytes? MaxContentSizeBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::OpenRouter.ModelInputV2Variant5ParamsReferences? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::OpenRouter.ModelInputV2Variant5ParamsSources? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant5Params" /> class.
        /// </summary>
        /// <param name="formats"></param>
        /// <param name="maxContentSizeBytes"></param>
        /// <param name="references"></param>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInputV2Variant5Params(
            global::OpenRouter.ModelInputV2Variant5ParamsFormats? formats,
            global::OpenRouter.ModelInputV2Variant5ParamsMaxContentSizeBytes? maxContentSizeBytes,
            global::OpenRouter.ModelInputV2Variant5ParamsReferences? references,
            global::OpenRouter.ModelInputV2Variant5ParamsSources? sources)
        {
            this.Formats = formats;
            this.MaxContentSizeBytes = maxContentSizeBytes;
            this.References = references;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant5Params" /> class.
        /// </summary>
        public ModelInputV2Variant5Params()
        {
        }

    }
}