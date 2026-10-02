
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:tool_search server tool<br/>
    /// Example: {"max_results":5}
    /// </summary>
    public sealed partial class ToolSearchServerToolConfig
    {
        /// <summary>
        /// Maximum tools returned by one search. Defaults to 5.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchServerToolConfig" /> class.
        /// </summary>
        /// <param name="maxResults">
        /// Maximum tools returned by one search. Defaults to 5.<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchServerToolConfig(
            int? maxResults)
        {
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchServerToolConfig" /> class.
        /// </summary>
        public ToolSearchServerToolConfig()
        {
        }

    }
}