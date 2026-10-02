
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Published lane configuration, included only when include_run_config=true. Only the agent turn count, reasoning effort, and temperature are exposed; other harness settings are intentionally not part of the public contract.
    /// </summary>
    public sealed partial class UnifiedBenchmarksSearchRunConfig
    {
        /// <summary>
        /// Agent-turn count for the published lane, or null for plugin lanes.<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_agent_turns")]
        public int? MaxAgentTurns { get; set; }

        /// <summary>
        /// Reasoning effort configured for the published lane, or null when omitted.<br/>
        /// Example: high
        /// </summary>
        /// <example>high</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        public string? ReasoningEffort { get; set; }

        /// <summary>
        /// Sampling temperature configured for the published lane, or null when omitted.<br/>
        /// Example: 0.2F
        /// </summary>
        /// <example>0.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksSearchRunConfig" /> class.
        /// </summary>
        /// <param name="maxAgentTurns">
        /// Agent-turn count for the published lane, or null for plugin lanes.<br/>
        /// Example: 25
        /// </param>
        /// <param name="reasoningEffort">
        /// Reasoning effort configured for the published lane, or null when omitted.<br/>
        /// Example: high
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature configured for the published lane, or null when omitted.<br/>
        /// Example: 0.2F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedBenchmarksSearchRunConfig(
            int? maxAgentTurns,
            string? reasoningEffort,
            double? temperature)
        {
            this.MaxAgentTurns = maxAgentTurns;
            this.ReasoningEffort = reasoningEffort;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedBenchmarksSearchRunConfig" /> class.
        /// </summary>
        public UnifiedBenchmarksSearchRunConfig()
        {
        }

    }
}