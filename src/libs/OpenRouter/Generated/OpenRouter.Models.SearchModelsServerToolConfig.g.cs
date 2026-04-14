
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:experimental__search_models server tool
    /// </summary>
    public sealed partial class SearchModelsServerToolConfig
    {
        /// <summary>
        /// Maximum number of models to return. Defaults to 5, max 20.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchModelsServerToolConfig" /> class.
        /// </summary>
        /// <param name="maxResults">
        /// Maximum number of models to return. Defaults to 5, max 20.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchModelsServerToolConfig(
            int? maxResults)
        {
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchModelsServerToolConfig" /> class.
        /// </summary>
        public SearchModelsServerToolConfig()
        {
        }
    }
}