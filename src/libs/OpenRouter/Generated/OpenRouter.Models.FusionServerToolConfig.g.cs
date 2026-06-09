
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
        /// Maximum number of output tokens (including reasoning tokens) each panelist and the judge model may produce per inner call. Controls the total output budget so reasoning-heavy models like GPT-5.5 do not exhaust their token allowance before producing visible text. When omitted, the provider's default applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

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
        /// Reasoning configuration forwarded to panelist and judge inner calls. Use this to control reasoning effort and token budget for models that support extended thinking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.FusionServerToolConfigReasoning? Reasoning { get; set; }

        /// <summary>
        /// Sampling temperature forwarded to panelist and judge inner calls. When omitted, the provider's default applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Server tools available to panelist and judge inner calls. Each entry uses the same `{ type, parameters? }` shorthand as the outer Chat Completions request. When omitted, defaults to `[{ type: "openrouter:web_search" }, { type: "openrouter:web_fetch" }]`. Pass an empty array to disable tools entirely (panelists answer from parametric knowledge only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionServerToolConfigToolsItems>? Tools { get; set; }

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
        /// <param name="maxCompletionTokens">
        /// Maximum number of output tokens (including reasoning tokens) each panelist and the judge model may produce per inner call. Controls the total output budget so reasoning-heavy models like GPT-5.5 do not exhaust their token allowance before producing visible text. When omitted, the provider's default applies.
        /// </param>
        /// <param name="maxToolCalls">
        /// Maximum number of tool-calling steps each panelist (analysis model) and the judge model may take during their agentic web-research loop. Models with web_search/web_fetch enabled iterate until they produce a text response or hit this ceiling. Defaults to 8. Capped at 16.
        /// </param>
        /// <param name="model">
        /// Slug of the judge model that produces the structured analysis JSON. Defaults to the model used in the outer API request.
        /// </param>
        /// <param name="reasoning">
        /// Reasoning configuration forwarded to panelist and judge inner calls. Use this to control reasoning effort and token budget for models that support extended thinking.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature forwarded to panelist and judge inner calls. When omitted, the provider's default applies.
        /// </param>
        /// <param name="tools">
        /// Server tools available to panelist and judge inner calls. Each entry uses the same `{ type, parameters? }` shorthand as the outer Chat Completions request. When omitted, defaults to `[{ type: "openrouter:web_search" }, { type: "openrouter:web_fetch" }]`. Pass an empty array to disable tools entirely (panelists answer from parametric knowledge only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionServerToolConfig(
            global::System.Collections.Generic.IList<string>? analysisModels,
            int? maxCompletionTokens,
            int? maxToolCalls,
            string? model,
            global::OpenRouter.FusionServerToolConfigReasoning? reasoning,
            double? temperature,
            global::System.Collections.Generic.IList<global::OpenRouter.FusionServerToolConfigToolsItems>? tools)
        {
            this.AnalysisModels = analysisModels;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxToolCalls = maxToolCalls;
            this.Model = model;
            this.Reasoning = reasoning;
            this.Temperature = temperature;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionServerToolConfig" /> class.
        /// </summary>
        public FusionServerToolConfig()
        {
        }

    }
}