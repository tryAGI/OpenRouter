
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:fusion server tool.<br/>
    /// Example: {"analysis_models":["~anthropic/claude-opus-latest","~openai/gpt-sol-latest","~google/gemini-pro-latest"]}
    /// </summary>
    public sealed partial class FusionServerToolConfig
    {
        /// <summary>
        /// Slugs of models to run in parallel as the analysis panel. Each model receives the user prompt with openrouter:web_search and openrouter:web_fetch enabled, then an analyst model summarizes the collective output into structured analysis JSON. Capped at 8 models to bound cost amplification. Defaults to the Quality preset from /labs/fusion.<br/>
        /// Example: [~anthropic/claude-opus-latest, ~openai/gpt-sol-latest, ~google/gemini-pro-latest]
        /// </summary>
        /// <example>[~anthropic/claude-opus-latest, ~openai/gpt-sol-latest, ~google/gemini-pro-latest]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_models")]
        public global::System.Collections.Generic.IList<string>? AnalysisModels { get; set; }

        /// <summary>
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </summary>
        /// <example>{"type":"ephemeral"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// Maximum number of output tokens (including reasoning tokens) each panelist and the analyst model may produce per inner call. Controls the total output budget so reasoning-heavy models like GPT-5.5 do not exhaust their token allowance before producing visible text. Defaults to 16000 when omitted.<br/>
        /// Example: 16384
        /// </summary>
        /// <example>16384</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Maximum number of tool-calling steps each panelist (analysis model) and the analyst model may take during their agentic web-research loop. Models with web_search/web_fetch enabled iterate until they produce a text response or hit this ceiling. Defaults to 4. Capped at 16.<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Slug of the analyst model that produces the structured analysis JSON. Defaults to the model used in the outer API request.<br/>
        /// Example: ~anthropic/claude-opus-latest
        /// </summary>
        /// <example>~anthropic/claude-opus-latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Reasoning configuration forwarded to panelist and analyst inner calls. Use this to control reasoning effort and token budget for models that support extended thinking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.FusionServerToolConfigReasoning? Reasoning { get; set; }

        /// <summary>
        /// Temperature forwarded to panelist inner calls. The analyst always runs at temperature 0 regardless of this value. When omitted, the provider's default applies.<br/>
        /// Example: 0.7F
        /// </summary>
        /// <example>0.7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Server tools available to panelist and analyst inner calls. Each entry uses the same `{ type, parameters? }` shorthand as the outer Chat Completions request. When omitted, defaults to `[{ type: "openrouter:web_search" }, { type: "openrouter:web_fetch" }]`. Pass an empty array to disable tools entirely (panelists answer from parametric knowledge only).<br/>
        /// Example: [{"parameters":{"excluded_domains":["example.com"]},"type":"openrouter:web_search"}, {"type":"openrouter:web_fetch"}]
        /// </summary>
        /// <example>[{"parameters":{"excluded_domains":["example.com"]},"type":"openrouter:web_search"}, {"type":"openrouter:web_fetch"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionServerToolConfigTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionServerToolConfig" /> class.
        /// </summary>
        /// <param name="analysisModels">
        /// Slugs of models to run in parallel as the analysis panel. Each model receives the user prompt with openrouter:web_search and openrouter:web_fetch enabled, then an analyst model summarizes the collective output into structured analysis JSON. Capped at 8 models to bound cost amplification. Defaults to the Quality preset from /labs/fusion.<br/>
        /// Example: [~anthropic/claude-opus-latest, ~openai/gpt-sol-latest, ~google/gemini-pro-latest]
        /// </param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of output tokens (including reasoning tokens) each panelist and the analyst model may produce per inner call. Controls the total output budget so reasoning-heavy models like GPT-5.5 do not exhaust their token allowance before producing visible text. Defaults to 16000 when omitted.<br/>
        /// Example: 16384
        /// </param>
        /// <param name="maxToolCalls">
        /// Maximum number of tool-calling steps each panelist (analysis model) and the analyst model may take during their agentic web-research loop. Models with web_search/web_fetch enabled iterate until they produce a text response or hit this ceiling. Defaults to 4. Capped at 16.<br/>
        /// Example: 12
        /// </param>
        /// <param name="model">
        /// Slug of the analyst model that produces the structured analysis JSON. Defaults to the model used in the outer API request.<br/>
        /// Example: ~anthropic/claude-opus-latest
        /// </param>
        /// <param name="reasoning">
        /// Reasoning configuration forwarded to panelist and analyst inner calls. Use this to control reasoning effort and token budget for models that support extended thinking.
        /// </param>
        /// <param name="temperature">
        /// Temperature forwarded to panelist inner calls. The analyst always runs at temperature 0 regardless of this value. When omitted, the provider's default applies.<br/>
        /// Example: 0.7F
        /// </param>
        /// <param name="tools">
        /// Server tools available to panelist and analyst inner calls. Each entry uses the same `{ type, parameters? }` shorthand as the outer Chat Completions request. When omitted, defaults to `[{ type: "openrouter:web_search" }, { type: "openrouter:web_fetch" }]`. Pass an empty array to disable tools entirely (panelists answer from parametric knowledge only).<br/>
        /// Example: [{"parameters":{"excluded_domains":["example.com"]},"type":"openrouter:web_search"}, {"type":"openrouter:web_fetch"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionServerToolConfig(
            global::System.Collections.Generic.IList<string>? analysisModels,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            int? maxCompletionTokens,
            int? maxToolCalls,
            string? model,
            global::OpenRouter.FusionServerToolConfigReasoning? reasoning,
            double? temperature,
            global::System.Collections.Generic.IList<global::OpenRouter.FusionServerToolConfigTool>? tools)
        {
            this.AnalysisModels = analysisModels;
            this.CacheControl = cacheControl;
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