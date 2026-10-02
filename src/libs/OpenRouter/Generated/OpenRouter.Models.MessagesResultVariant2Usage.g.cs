
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesResultVariant2Usage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Breakdown of upstream inference costs<br/>
        /// Example: {"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008}
        /// </summary>
        /// <example>{"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_details")]
        public global::OpenRouter.CostDetails? CostDetails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterations")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? Iterations { get; set; }

        /// <summary>
        /// Example: {"tool_calls_executed":1,"tool_calls_requested":1,"web_fetch_requests":0,"web_search_requests":0}
        /// </summary>
        /// <example>{"tool_calls_executed":1,"tool_calls_requested":1,"web_fetch_requests":0,"web_search_requests":0}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        public global::OpenRouter.ORAnthropicServerToolUsage? ServerToolUse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicSpeedJsonConverter))]
        public global::OpenRouter.AnthropicSpeed? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultVariant2Usage" /> class.
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="costDetails">
        /// Breakdown of upstream inference costs<br/>
        /// Example: {"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008}
        /// </param>
        /// <param name="isByok"></param>
        /// <param name="iterations"></param>
        /// <param name="serverToolUse">
        /// Example: {"tool_calls_executed":1,"tool_calls_requested":1,"web_fetch_requests":0,"web_search_requests":0}
        /// </param>
        /// <param name="serviceTier"></param>
        /// <param name="speed">
        /// Example: standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResultVariant2Usage(
            double? cost,
            global::OpenRouter.CostDetails? costDetails,
            bool? isByok,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? iterations,
            global::OpenRouter.ORAnthropicServerToolUsage? serverToolUse,
            string? serviceTier,
            global::OpenRouter.AnthropicSpeed? speed)
        {
            this.Cost = cost;
            this.CostDetails = costDetails;
            this.IsByok = isByok;
            this.Iterations = iterations;
            this.ServerToolUse = serverToolUse;
            this.ServiceTier = serviceTier;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultVariant2Usage" /> class.
        /// </summary>
        public MessagesResultVariant2Usage()
        {
        }

    }
}