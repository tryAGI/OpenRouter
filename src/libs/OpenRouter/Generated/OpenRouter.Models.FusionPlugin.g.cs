
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"analysis_models":["~anthropic/claude-opus-latest","~openai/gpt-sol-latest","~google/gemini-pro-latest"],"enabled":true,"id":"fusion","model":"~anthropic/claude-opus-latest"}
    /// </summary>
    public sealed partial class FusionPlugin
    {
        /// <summary>
        /// For a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool, slugs of models to run in parallel as the "expert panel" the analyst analyzes. Each model receives the same user prompt with web_search + web_fetch enabled. Capped at 8 models to bound cost amplification. When omitted, defaults to the Quality preset from the /labs/fusion UI (~anthropic/claude-opus-latest, ~openai/gpt-sol-latest, ~google/gemini-pro-latest).<br/>
        /// Example: [~anthropic/claude-opus-latest, ~openai/gpt-sol-latest, ~google/gemini-pro-latest]
        /// </summary>
        /// <example>[~anthropic/claude-opus-latest, ~openai/gpt-sol-latest, ~google/gemini-pro-latest]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_models")]
        public global::System.Collections.Generic.IList<string>? AnalysisModels { get; set; }

        /// <summary>
        /// Set to false to disable Fusion configuration for a run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FusionPluginIdJsonConverter))]
        public global::OpenRouter.FusionPluginId Id { get; set; }

        /// <summary>
        /// For a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool, the maximum number of tool-calling steps each panelist (analysis model) and the analyst model may take during their agentic web-research loop. Models with web_search/web_fetch enabled iterate until they produce a text response or hit this ceiling. Defaults to 4. Capped at 16.<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// For a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool, the slug of the model that performs both the analyst step (with web_search + web_fetch) and the final synthesis. When omitted, defaults to the first model in the Quality preset.<br/>
        /// Example: ~anthropic/claude-opus-latest
        /// </summary>
        /// <example>~anthropic/claude-opus-latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Configuration for a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool. A curated OpenRouter preset (slugs follow `&lt;task&gt;-&lt;tier&gt;`, e.g. `general-high`). Expands server-side into the preset's analysis_models panel and analyst model, so callers never name individual models. Explicitly provided `analysis_models` / `model` take precedence.<br/>
        /// Example: general-high
        /// </summary>
        /// <example>general-high</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FusionPluginPresetJsonConverter))]
        public global::OpenRouter.FusionPluginPreset? Preset { get; set; }

        /// <summary>
        /// For a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool, server tools available to panelist and analyst inner calls. Each entry uses the same `{ type, parameters? }` shorthand as the outer Chat Completions request. When omitted, defaults to `[{ type: "openrouter:web_search" }, { type: "openrouter:web_fetch" }]`. Pass an empty array to disable tools entirely (panelists answer from parametric knowledge only).<br/>
        /// Example: [{"parameters":{"excluded_domains":["example.com"]},"type":"openrouter:web_search"}, {"type":"openrouter:web_fetch"}]
        /// </summary>
        /// <example>[{"parameters":{"excluded_domains":["example.com"]},"type":"openrouter:web_search"}, {"type":"openrouter:web_fetch"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionPluginTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionPlugin" /> class.
        /// </summary>
        /// <param name="analysisModels">
        /// For a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool, slugs of models to run in parallel as the "expert panel" the analyst analyzes. Each model receives the same user prompt with web_search + web_fetch enabled. Capped at 8 models to bound cost amplification. When omitted, defaults to the Quality preset from the /labs/fusion UI (~anthropic/claude-opus-latest, ~openai/gpt-sol-latest, ~google/gemini-pro-latest).<br/>
        /// Example: [~anthropic/claude-opus-latest, ~openai/gpt-sol-latest, ~google/gemini-pro-latest]
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable Fusion configuration for a run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool. Defaults to true.
        /// </param>
        /// <param name="id"></param>
        /// <param name="maxToolCalls">
        /// For a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool, the maximum number of tool-calling steps each panelist (analysis model) and the analyst model may take during their agentic web-research loop. Models with web_search/web_fetch enabled iterate until they produce a text response or hit this ceiling. Defaults to 4. Capped at 16.<br/>
        /// Example: 12
        /// </param>
        /// <param name="model">
        /// For a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool, the slug of the model that performs both the analyst step (with web_search + web_fetch) and the final synthesis. When omitted, defaults to the first model in the Quality preset.<br/>
        /// Example: ~anthropic/claude-opus-latest
        /// </param>
        /// <param name="preset">
        /// Configuration for a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool. A curated OpenRouter preset (slugs follow `&lt;task&gt;-&lt;tier&gt;`, e.g. `general-high`). Expands server-side into the preset's analysis_models panel and analyst model, so callers never name individual models. Explicitly provided `analysis_models` / `model` take precedence.<br/>
        /// Example: general-high
        /// </param>
        /// <param name="tools">
        /// For a Fusion run started by the `openrouter/fusion` model slug or `openrouter:fusion` server tool, server tools available to panelist and analyst inner calls. Each entry uses the same `{ type, parameters? }` shorthand as the outer Chat Completions request. When omitted, defaults to `[{ type: "openrouter:web_search" }, { type: "openrouter:web_fetch" }]`. Pass an empty array to disable tools entirely (panelists answer from parametric knowledge only).<br/>
        /// Example: [{"parameters":{"excluded_domains":["example.com"]},"type":"openrouter:web_search"}, {"type":"openrouter:web_fetch"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionPlugin(
            global::System.Collections.Generic.IList<string>? analysisModels,
            bool? enabled,
            global::OpenRouter.FusionPluginId id,
            int? maxToolCalls,
            string? model,
            global::OpenRouter.FusionPluginPreset? preset,
            global::System.Collections.Generic.IList<global::OpenRouter.FusionPluginTool>? tools)
        {
            this.AnalysisModels = analysisModels;
            this.Enabled = enabled;
            this.Id = id;
            this.MaxToolCalls = maxToolCalls;
            this.Model = model;
            this.Preset = preset;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionPlugin" /> class.
        /// </summary>
        public FusionPlugin()
        {
        }

    }
}