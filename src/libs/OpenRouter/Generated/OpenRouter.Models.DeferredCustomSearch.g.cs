
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Caller-executed search returning existing tool identities under result_key.<br/>
    /// Example: {"max_results":5,"result_key":"tool_names","tool_id":"search_catalog","type":"custom"}
    /// </summary>
    public sealed partial class DeferredCustomSearch
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResultKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredCustomSearchTypeJsonConverter))]
        public global::OpenRouter.DeferredCustomSearchType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredCustomSearch" /> class.
        /// </summary>
        /// <param name="resultKey"></param>
        /// <param name="toolId"></param>
        /// <param name="maxResults"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeferredCustomSearch(
            string resultKey,
            string toolId,
            int? maxResults,
            global::OpenRouter.DeferredCustomSearchType type)
        {
            this.MaxResults = maxResults;
            this.ResultKey = resultKey ?? throw new global::System.ArgumentNullException(nameof(resultKey));
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredCustomSearch" /> class.
        /// </summary>
        public DeferredCustomSearch()
        {
        }

    }
}