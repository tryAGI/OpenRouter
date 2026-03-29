
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultUsage
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageCacheCreation, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageCacheCreation, object> CacheCreation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_geo")]
        public string? InferenceGeo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageServerToolUse, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageServerToolUse, object> ServerToolUse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageServiceTier?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageServiceTier?, object> ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageSpeed?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageSpeed?, object>? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultUsage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="cacheCreation"></param>
        /// <param name="serverToolUse"></param>
        /// <param name="serviceTier"></param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
        /// <param name="inferenceGeo"></param>
        /// <param name="speed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultUsage(
            double inputTokens,
            double outputTokens,
            global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageCacheCreation, object> cacheCreation,
            global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageServerToolUse, object> serverToolUse,
            global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageServiceTier?, object> serviceTier,
            double? cacheCreationInputTokens,
            double? cacheReadInputTokens,
            string? inferenceGeo,
            global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageSpeed?, object>? speed)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreation = cacheCreation;
            this.InferenceGeo = inferenceGeo;
            this.ServerToolUse = serverToolUse;
            this.ServiceTier = serviceTier;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultUsage" /> class.
        /// </summary>
        public BaseMessagesResultUsage()
        {
        }
    }
}