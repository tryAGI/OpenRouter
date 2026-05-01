
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// content_block_location variant
    /// </summary>
    public sealed partial class AnthropicTextBlockParamCitationsItemsVariant2
    {
        /// <summary>
        /// Discriminator value: content_block_location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant2TypeJsonConverter))]
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2Type Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextBlockParamCitationsItemsVariant2" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="endBlockIndex"></param>
        /// <param name="startBlockIndex"></param>
        /// <param name="type">
        /// Discriminator value: content_block_location
        /// </param>
        /// <param name="documentTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTextBlockParamCitationsItemsVariant2(
            string citedText,
            int documentIndex,
            int endBlockIndex,
            int startBlockIndex,
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2Type type,
            string? documentTitle)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle;
            this.EndBlockIndex = endBlockIndex;
            this.StartBlockIndex = startBlockIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextBlockParamCitationsItemsVariant2" /> class.
        /// </summary>
        public AnthropicTextBlockParamCitationsItemsVariant2()
        {
        }
    }
}