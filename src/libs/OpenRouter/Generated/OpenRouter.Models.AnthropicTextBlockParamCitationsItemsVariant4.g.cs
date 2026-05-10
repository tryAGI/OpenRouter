
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// search_result_location variant
    /// </summary>
    public sealed partial class AnthropicTextBlockParamCitationsItemsVariant4
    {
        /// <summary>
        /// Discriminator value: search_result_location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant4TypeJsonConverter))]
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_result_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SearchResultIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextBlockParamCitationsItemsVariant4" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="endBlockIndex"></param>
        /// <param name="searchResultIndex"></param>
        /// <param name="source"></param>
        /// <param name="startBlockIndex"></param>
        /// <param name="type">
        /// Discriminator value: search_result_location
        /// </param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTextBlockParamCitationsItemsVariant4(
            string citedText,
            int endBlockIndex,
            int searchResultIndex,
            string source,
            int startBlockIndex,
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4Type type,
            string? title)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.EndBlockIndex = endBlockIndex;
            this.SearchResultIndex = searchResultIndex;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.StartBlockIndex = startBlockIndex;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextBlockParamCitationsItemsVariant4" /> class.
        /// </summary>
        public AnthropicTextBlockParamCitationsItemsVariant4()
        {
        }

    }
}