
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionCostItem
    {
        /// <summary>
        /// Published harness display label.<br/>
        /// Example: Hermes Agent
        /// </summary>
        /// <example>Hermes Agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// Stable public slug of the harness.<br/>
        /// Example: hermes-agent
        /// </summary>
        /// <example>hermes-agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppSlug { get; set; }

        /// <summary>
        /// Median USD spend per sampled session.<br/>
        /// Example: 1.74F
        /// </summary>
        /// <example>1.74F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("median_session_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MedianSessionCostUsd { get; set; }

        /// <summary>
        /// Exact model permaslug.<br/>
        /// Example: anthropic/claude-4.8-opus
        /// </summary>
        /// <example>anthropic/claude-4.8-opus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// Inclusive session turn-count range.<br/>
        /// Example: 10-49-turns
        /// </summary>
        /// <example>10-49-turns</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SessionCostItemTurnRangeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SessionCostItemTurnRange TurnRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCostItem" /> class.
        /// </summary>
        /// <param name="appName">
        /// Published harness display label.<br/>
        /// Example: Hermes Agent
        /// </param>
        /// <param name="appSlug">
        /// Stable public slug of the harness.<br/>
        /// Example: hermes-agent
        /// </param>
        /// <param name="medianSessionCostUsd">
        /// Median USD spend per sampled session.<br/>
        /// Example: 1.74F
        /// </param>
        /// <param name="modelPermaslug">
        /// Exact model permaslug.<br/>
        /// Example: anthropic/claude-4.8-opus
        /// </param>
        /// <param name="turnRange">
        /// Inclusive session turn-count range.<br/>
        /// Example: 10-49-turns
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionCostItem(
            string appName,
            string appSlug,
            double medianSessionCostUsd,
            string modelPermaslug,
            global::OpenRouter.SessionCostItemTurnRange turnRange)
        {
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.AppSlug = appSlug ?? throw new global::System.ArgumentNullException(nameof(appSlug));
            this.MedianSessionCostUsd = medianSessionCostUsd;
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.TurnRange = turnRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCostItem" /> class.
        /// </summary>
        public SessionCostItem()
        {
        }

    }
}