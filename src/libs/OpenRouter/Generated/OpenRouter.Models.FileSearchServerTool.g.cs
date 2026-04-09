
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// File search tool configuration
    /// </summary>
    public sealed partial class FileSearchServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersJsonConverter))]
        public global::OpenRouter.FileSearchServerToolFilters? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking_options")]
        public global::OpenRouter.FileSearchServerToolRankingOptions? RankingOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FileSearchServerToolTypeJsonConverter))]
        public global::OpenRouter.FileSearchServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VectorStoreIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchServerTool" /> class.
        /// </summary>
        /// <param name="vectorStoreIds"></param>
        /// <param name="filters"></param>
        /// <param name="maxNumResults"></param>
        /// <param name="rankingOptions"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchServerTool(
            global::System.Collections.Generic.IList<string> vectorStoreIds,
            global::OpenRouter.FileSearchServerToolFilters? filters,
            int? maxNumResults,
            global::OpenRouter.FileSearchServerToolRankingOptions? rankingOptions,
            global::OpenRouter.FileSearchServerToolType type)
        {
            this.Filters = filters;
            this.MaxNumResults = maxNumResults;
            this.RankingOptions = rankingOptions;
            this.Type = type;
            this.VectorStoreIds = vectorStoreIds ?? throw new global::System.ArgumentNullException(nameof(vectorStoreIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchServerTool" /> class.
        /// </summary>
        public FileSearchServerTool()
        {
        }
    }
}