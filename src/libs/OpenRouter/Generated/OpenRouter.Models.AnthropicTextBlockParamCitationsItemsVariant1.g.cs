
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// char_location variant
    /// </summary>
    public sealed partial class AnthropicTextBlockParamCitationsItemsVariant1
    {
        /// <summary>
        /// Discriminator value: char_location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant1TypeJsonConverter))]
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1Type Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("end_char_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndCharIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_char_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartCharIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextBlockParamCitationsItemsVariant1" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="endCharIndex"></param>
        /// <param name="startCharIndex"></param>
        /// <param name="type">
        /// Discriminator value: char_location
        /// </param>
        /// <param name="documentTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTextBlockParamCitationsItemsVariant1(
            string citedText,
            int documentIndex,
            int endCharIndex,
            int startCharIndex,
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1Type type,
            string? documentTitle)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle;
            this.EndCharIndex = endCharIndex;
            this.StartCharIndex = startCharIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextBlockParamCitationsItemsVariant1" /> class.
        /// </summary>
        public AnthropicTextBlockParamCitationsItemsVariant1()
        {
        }
    }
}