
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicCitationContentBlockLocationParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_title")]
        public string? DocumentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicCitationContentBlockLocationParamTypeJsonConverter))]
        public global::OpenRouter.AnthropicCitationContentBlockLocationParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicCitationContentBlockLocationParam" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="endBlockIndex"></param>
        /// <param name="startBlockIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicCitationContentBlockLocationParam(
            string citedText,
            int documentIndex,
            int endBlockIndex,
            int startBlockIndex,
            string? documentTitle,
            global::OpenRouter.AnthropicCitationContentBlockLocationParamType type)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle;
            this.EndBlockIndex = endBlockIndex;
            this.StartBlockIndex = startBlockIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicCitationContentBlockLocationParam" /> class.
        /// </summary>
        public AnthropicCitationContentBlockLocationParam()
        {
        }
    }
}