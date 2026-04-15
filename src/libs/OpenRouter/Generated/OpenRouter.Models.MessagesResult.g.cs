
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Non-streaming response from the Anthropic Messages API with OpenRouter extensions
    /// </summary>
    public sealed partial class MessagesResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicContainer Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicContentBlock> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseMessagesResultRoleJsonConverter))]
        public global::OpenRouter.BaseMessagesResultRole Role { get; set; }

        /// <summary>
        /// Structured information about a refusal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicRefusalStopDetails StopDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicStopReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ORAnthropicStopReason StopReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseMessagesResultTypeJsonConverter))]
        public global::OpenRouter.BaseMessagesResultType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesResultUsage Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_management")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultContextManagement, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesResultContextManagement, object>? ContextManagement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ProviderNameJsonConverter))]
        public global::OpenRouter.ProviderName? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResult" /> class.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="stopDetails">
        /// Structured information about a refusal
        /// </param>
        /// <param name="stopReason"></param>
        /// <param name="usage"></param>
        /// <param name="role"></param>
        /// <param name="stopSequence"></param>
        /// <param name="type"></param>
        /// <param name="contextManagement"></param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResult(
            global::OpenRouter.AnthropicContainer container,
            global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicContentBlock> content,
            string id,
            string model,
            global::OpenRouter.AnthropicRefusalStopDetails stopDetails,
            global::OpenRouter.ORAnthropicStopReason stopReason,
            global::OpenRouter.MessagesResultUsage usage,
            global::OpenRouter.BaseMessagesResultRole role,
            string? stopSequence,
            global::OpenRouter.BaseMessagesResultType type,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesResultContextManagement, object>? contextManagement,
            global::OpenRouter.ProviderName? provider)
        {
            this.Container = container ?? throw new global::System.ArgumentNullException(nameof(container));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Role = role;
            this.StopDetails = stopDetails ?? throw new global::System.ArgumentNullException(nameof(stopDetails));
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
            this.Type = type;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.ContextManagement = contextManagement;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResult" /> class.
        /// </summary>
        public MessagesResult()
        {
        }
    }
}