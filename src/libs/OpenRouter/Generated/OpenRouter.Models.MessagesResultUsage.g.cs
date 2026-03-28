
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesResultUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public double? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public double? CacheReadInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageCacheCreation, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageCacheCreation, object> CacheCreation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_geo")]
        public string? InferenceGeo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageServerToolUse, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageServerToolUse, object> ServerToolUse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageSpeed?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageSpeed?, object>? Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageCostDetails, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageCostDetails, object>? CostDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
        /// <param name="cacheCreation"></param>
        /// <param name="inferenceGeo"></param>
        /// <param name="serverToolUse"></param>
        /// <param name="serviceTier"></param>
        /// <param name="speed"></param>
        /// <param name="cost"></param>
        /// <param name="isByok"></param>
        /// <param name="costDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResultUsage(
            double inputTokens,
            double outputTokens,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageCacheCreation, object> cacheCreation,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageServerToolUse, object> serverToolUse,
            double? cacheCreationInputTokens,
            double? cacheReadInputTokens,
            string? inferenceGeo,
            string? serviceTier,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageSpeed?, object>? speed,
            double? cost,
            bool? isByok,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageCostDetails, object>? costDetails)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheCreation = cacheCreation;
            this.ServerToolUse = serverToolUse;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.InferenceGeo = inferenceGeo;
            this.ServiceTier = serviceTier;
            this.Speed = speed;
            this.Cost = cost;
            this.IsByok = isByok;
            this.CostDetails = costDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsage" /> class.
        /// </summary>
        public MessagesResultUsage()
        {
        }
    }
}