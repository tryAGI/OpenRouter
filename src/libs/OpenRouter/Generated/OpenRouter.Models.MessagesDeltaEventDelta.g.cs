
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesDeltaEventDelta
    {
        /// <summary>
        /// Example: {"expires_at":"2026-04-08T00:00:00Z","id":"ctr_01abc","skills":null}
        /// </summary>
        /// <example>{"expires_at":"2026-04-08T00:00:00Z","id":"ctr_01abc","skills":null}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        public global::OpenRouter.AnthropicContainer? Container { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safeguard_results")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguardResult>? SafeguardResults { get; set; }

        /// <summary>
        /// Structured information about a refusal<br/>
        /// Example: {"category":"cyber","explanation":"The request was refused due to policy.","type":"refusal"}
        /// </summary>
        /// <example>{"category":"cyber","explanation":"The request was refused due to policy.","type":"refusal"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_details")]
        public global::OpenRouter.AnthropicRefusalStopDetails? StopDetails { get; set; }

        /// <summary>
        /// Example: end_turn
        /// </summary>
        /// <example>end_turn</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicStopReasonJsonConverter))]
        public global::OpenRouter.ORAnthropicStopReason? StopReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesDeltaEventDelta" /> class.
        /// </summary>
        /// <param name="container">
        /// Example: {"expires_at":"2026-04-08T00:00:00Z","id":"ctr_01abc","skills":null}
        /// </param>
        /// <param name="safeguardResults"></param>
        /// <param name="stopDetails">
        /// Structured information about a refusal<br/>
        /// Example: {"category":"cyber","explanation":"The request was refused due to policy.","type":"refusal"}
        /// </param>
        /// <param name="stopReason">
        /// Example: end_turn
        /// </param>
        /// <param name="stopSequence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesDeltaEventDelta(
            global::OpenRouter.AnthropicContainer? container,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguardResult>? safeguardResults,
            global::OpenRouter.AnthropicRefusalStopDetails? stopDetails,
            global::OpenRouter.ORAnthropicStopReason? stopReason,
            string? stopSequence)
        {
            this.Container = container;
            this.SafeguardResults = safeguardResults;
            this.StopDetails = stopDetails;
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesDeltaEventDelta" /> class.
        /// </summary>
        public MessagesDeltaEventDelta()
        {
        }

    }
}