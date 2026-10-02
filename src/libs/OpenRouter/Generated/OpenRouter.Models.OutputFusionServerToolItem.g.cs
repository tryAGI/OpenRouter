
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:fusion server tool output item<br/>
    /// Example: {"id":"st_tmp_abc123","status":"completed","type":"openrouter:fusion"}
    /// </summary>
    public sealed partial class OutputFusionServerToolItem
    {
        /// <summary>
        /// Structured analysis produced by the fusion analyst model.<br/>
        /// Example: {"blind_spots":["No model considered the impact on existing API consumers."],"consensus":["All panel models agree the request is asking for a concise summary."],"contradictions":[{"stances":[{"model":"openai/gpt-5","stance":"Favors an incremental rollout."},{"model":"anthropic/claude-sonnet-4.5","stance":"Favors a single coordinated migration."}],"topic":"Recommended approach"}],"partial_coverage":[{"models":["openai/gpt-5"],"point":"Only one model addressed the rollback strategy."}],"unique_insights":[{"insight":"Highlighted a backwards-compatibility risk the other models missed.","model":"anthropic/claude-sonnet-4.5"}]}
        /// </summary>
        /// <example>{"blind_spots":["No model considered the impact on existing API consumers."],"consensus":["All panel models agree the request is asking for a concise summary."],"contradictions":[{"stances":[{"model":"openai/gpt-5","stance":"Favors an incremental rollout."},{"model":"anthropic/claude-sonnet-4.5","stance":"Favors a single coordinated migration."}],"topic":"Recommended approach"}],"partial_coverage":[{"models":["openai/gpt-5"],"point":"Only one model addressed the rollback strategy."}],"unique_insights":[{"insight":"Highlighted a backwards-compatibility risk the other models missed.","model":"anthropic/claude-sonnet-4.5"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        public global::OpenRouter.FusionAnalysisResult? Analysis { get; set; }

        /// <summary>
        /// Error message when the fusion run did not produce an analysis result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Models that were requested as part of the analysis panel but did not produce a response. Present when at least one requested analysis model failed. On a completed item the fusion result is still usable but was produced from a degraded panel; on a failed item it lists the panels that failed before the run stopped, so the caller can see which models were attempted even though no analysis was produced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_models")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFusionServerToolItemFailedModel>? FailedModels { get; set; }

        /// <summary>
        /// Typed failure reason when the fusion run failed. Possible values include: all_panels_failed, insufficient_credits, rate_limited, invalid_model, judge_not_valid_json, judge_schema_mismatch, judge_upstream_error, judge_empty_completion. The four analysis-stage codes keep their pre-rename `judge_` spelling so existing consumers keep matching. The consumer-cancellation code is `cancelled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Analysis models that produced a response in this fusion run, with each model's full panel content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responses")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFusionServerToolItemResponse>? Responses { get; set; }

        /// <summary>
        /// Web pages the analysis panels and analyst retrieved via web search during this fusion run, deduplicated by URL across the whole run. Present when at least one model cited a source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionSource>? Sources { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputFusionServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputFusionServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFusionServerToolItem" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="analysis">
        /// Structured analysis produced by the fusion analyst model.<br/>
        /// Example: {"blind_spots":["No model considered the impact on existing API consumers."],"consensus":["All panel models agree the request is asking for a concise summary."],"contradictions":[{"stances":[{"model":"openai/gpt-5","stance":"Favors an incremental rollout."},{"model":"anthropic/claude-sonnet-4.5","stance":"Favors a single coordinated migration."}],"topic":"Recommended approach"}],"partial_coverage":[{"models":["openai/gpt-5"],"point":"Only one model addressed the rollback strategy."}],"unique_insights":[{"insight":"Highlighted a backwards-compatibility risk the other models missed.","model":"anthropic/claude-sonnet-4.5"}]}
        /// </param>
        /// <param name="error">
        /// Error message when the fusion run did not produce an analysis result.
        /// </param>
        /// <param name="failedModels">
        /// Models that were requested as part of the analysis panel but did not produce a response. Present when at least one requested analysis model failed. On a completed item the fusion result is still usable but was produced from a degraded panel; on a failed item it lists the panels that failed before the run stopped, so the caller can see which models were attempted even though no analysis was produced.
        /// </param>
        /// <param name="failureReason">
        /// Typed failure reason when the fusion run failed. Possible values include: all_panels_failed, insufficient_credits, rate_limited, invalid_model, judge_not_valid_json, judge_schema_mismatch, judge_upstream_error, judge_empty_completion. The four analysis-stage codes keep their pre-rename `judge_` spelling so existing consumers keep matching. The consumer-cancellation code is `cancelled`.
        /// </param>
        /// <param name="id"></param>
        /// <param name="responses">
        /// Analysis models that produced a response in this fusion run, with each model's full panel content.
        /// </param>
        /// <param name="sources">
        /// Web pages the analysis panels and analyst retrieved via web search during this fusion run, deduplicated by URL across the whole run. Present when at least one model cited a source.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFusionServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.FusionAnalysisResult? analysis,
            string? error,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputFusionServerToolItemFailedModel>? failedModels,
            string? failureReason,
            string? id,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputFusionServerToolItemResponse>? responses,
            global::System.Collections.Generic.IList<global::OpenRouter.FusionSource>? sources,
            global::OpenRouter.OutputFusionServerToolItemType type)
        {
            this.Analysis = analysis;
            this.Error = error;
            this.FailedModels = failedModels;
            this.FailureReason = failureReason;
            this.Id = id;
            this.Responses = responses;
            this.Sources = sources;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFusionServerToolItem" /> class.
        /// </summary>
        public OutputFusionServerToolItem()
        {
        }

    }
}