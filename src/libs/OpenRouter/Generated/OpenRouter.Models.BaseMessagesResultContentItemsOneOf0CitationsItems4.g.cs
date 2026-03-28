
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf0CitationsItems4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4TypeJsonConverter))]
        public global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_result_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SearchResultIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

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
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf0CitationsItems4" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="citedText"></param>
        /// <param name="searchResultIndex"></param>
        /// <param name="source"></param>
        /// <param name="title"></param>
        /// <param name="startBlockIndex"></param>
        /// <param name="endBlockIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItemsOneOf0CitationsItems4(
            string citedText,
            double searchResultIndex,
            string source,
            double startBlockIndex,
            double endBlockIndex,
            global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4Type type,
            string? title)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.SearchResultIndex = searchResultIndex;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.StartBlockIndex = startBlockIndex;
            this.EndBlockIndex = endBlockIndex;
            this.Type = type;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf0CitationsItems4" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf0CitationsItems4()
        {
        }
    }
}