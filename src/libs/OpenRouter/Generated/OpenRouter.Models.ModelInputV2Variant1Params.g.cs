
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelInputV2Variant1Params
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_length")]
        public global::OpenRouter.ModelInputV2Variant1ParamsMaxLength? MaxLength { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_length")]
        public global::OpenRouter.ModelInputV2Variant1ParamsMaxPromptLength? MaxPromptLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant1Params" /> class.
        /// </summary>
        /// <param name="maxLength"></param>
        /// <param name="maxPromptLength"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInputV2Variant1Params(
            global::OpenRouter.ModelInputV2Variant1ParamsMaxLength? maxLength,
            global::OpenRouter.ModelInputV2Variant1ParamsMaxPromptLength? maxPromptLength)
        {
            this.MaxLength = maxLength;
            this.MaxPromptLength = maxPromptLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant1Params" /> class.
        /// </summary>
        public ModelInputV2Variant1Params()
        {
        }

    }
}