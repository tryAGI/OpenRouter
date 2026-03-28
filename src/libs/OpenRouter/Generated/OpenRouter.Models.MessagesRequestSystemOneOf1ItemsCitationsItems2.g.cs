
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestSystemOneOf1ItemsCitationsItems2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2Type Type { get; set; }

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
        public required double DocumentIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_title")]
        public string? DocumentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndBlockIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestSystemOneOf1ItemsCitationsItems2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="startBlockIndex"></param>
        /// <param name="endBlockIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestSystemOneOf1ItemsCitationsItems2(
            string citedText,
            double documentIndex,
            double startBlockIndex,
            double endBlockIndex,
            global::OpenRouter.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2Type type,
            string? documentTitle)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.StartBlockIndex = startBlockIndex;
            this.EndBlockIndex = endBlockIndex;
            this.Type = type;
            this.DocumentTitle = documentTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestSystemOneOf1ItemsCitationsItems2" /> class.
        /// </summary>
        public MessagesRequestSystemOneOf1ItemsCitationsItems2()
        {
        }
    }
}