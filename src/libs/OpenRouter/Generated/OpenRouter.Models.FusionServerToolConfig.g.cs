
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:fusion server tool.
    /// </summary>
    public sealed partial class FusionServerToolConfig
    {
        /// <summary>
        /// Slugs of models to run in parallel as the analysis panel. Each model receives the user prompt with openrouter:web_search and openrouter:web_fetch enabled, then a judge model summarizes the collective output into structured analysis JSON. Capped at 8 models to bound cost amplification. Defaults to the Quality preset from /labs/fusion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_models")]
        public global::System.Collections.Generic.IList<string>? AnalysisModels { get; set; }

        /// <summary>
        /// Maximum number of tool-calling steps each panelist (analysis model) and the judge model may take during their agentic web-research loop. Models with web_search/web_fetch enabled iterate until they produce a text response or hit this ceiling. Defaults to 8. Capped at 16.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Slug of the judge model that produces the structured analysis JSON. Defaults to the model used in the outer API request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionServerToolConfig" /> class.
        /// </summary>
        /// <param name="analysisModels">
        /// Slugs of models to run in parallel as the analysis panel. Each model receives the user prompt with openrouter:web_search and openrouter:web_fetch enabled, then a judge model summarizes the collective output into structured analysis JSON. Capped at 8 models to bound cost amplification. Defaults to the Quality preset from /labs/fusion.
        /// </param>
        /// <param name="maxToolCalls">
        /// Maximum number of tool-calling steps each panelist (analysis model) and the judge model may take during their agentic web-research loop. Models with web_search/web_fetch enabled iterate until they produce a text response or hit this ceiling. Defaults to 8. Capped at 16.
        /// </param>
        /// <param name="model">
        /// Slug of the judge model that produces the structured analysis JSON. Defaults to the model used in the outer API request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionServerToolConfig(
            global::System.Collections.Generic.IList<string>? analysisModels,
            int? maxToolCalls,
            string? model)
        {
            this.AnalysisModels = analysisModels;
            this.MaxToolCalls = maxToolCalls;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionServerToolConfig" /> class.
        /// </summary>
        public FusionServerToolConfig()
        {
        }

    }
}