
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputWebSearchCallItemAction0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<string>? Queries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::OpenRouter.WebSearchSource>? Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputWebSearchCallItemActionOneOf0TypeJsonConverter))]
        public global::OpenRouter.OutputWebSearchCallItemActionOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputWebSearchCallItemAction0" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="queries"></param>
        /// <param name="sources"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputWebSearchCallItemAction0(
            string query,
            global::System.Collections.Generic.IList<string>? queries,
            global::System.Collections.Generic.IList<global::OpenRouter.WebSearchSource>? sources,
            global::OpenRouter.OutputWebSearchCallItemActionOneOf0Type type)
        {
            this.Queries = queries;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Sources = sources;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputWebSearchCallItemAction0" /> class.
        /// </summary>
        public OutputWebSearchCallItemAction0()
        {
        }

    }
}