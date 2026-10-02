
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Base Anthropic Messages API response before OpenRouter extensions<br/>
    /// Example: {"container":null,"content":[{"citations":[],"text":"Hello!","type":"text"}],"id":"msg_01XFDUDYJgAACzvnptvVoYEL","model":"claude-sonnet-4-5-20250929","role":"assistant","stop_details":null,"stop_reason":"end_turn","stop_sequence":null,"type":"message","usage":{"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":12,"output_tokens":8,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}}
    /// </summary>
    public sealed partial class BaseMessagesResult
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
        [global::System.Text.Json.Serialization.JsonPropertyName("input_transformations")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicInputTransformation>? InputTransformations { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseMessagesResultTypeJsonConverter))]
        public global::OpenRouter.BaseMessagesResultType Type { get; set; }

        /// <summary>
        /// Example: {"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":100,"output_tokens":50,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}
        /// </summary>
        /// <example>{"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":100,"output_tokens":50,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.AnthropicUsage, global::OpenRouter.BaseMessagesResultUsage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.BaseMessagesResultUsage> Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResult" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="usage">
        /// Example: {"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":100,"output_tokens":50,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}
        /// </param>
        /// <param name="container">
        /// Example: {"expires_at":"2026-04-08T00:00:00Z","id":"ctr_01abc","skills":null}
        /// </param>
        /// <param name="inputTransformations"></param>
        /// <param name="role"></param>
        /// <param name="stopDetails">
        /// Structured information about a refusal<br/>
        /// Example: {"category":"cyber","explanation":"The request was refused due to policy.","type":"refusal"}
        /// </param>
        /// <param name="stopReason">
        /// Example: end_turn
        /// </param>
        /// <param name="stopSequence"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResult(
            global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicContentBlock> content,
            string id,
            string model,
            global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.BaseMessagesResultUsage> usage,
            global::OpenRouter.AnthropicContainer? container,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicInputTransformation>? inputTransformations,
            global::OpenRouter.BaseMessagesResultRole role,
            global::OpenRouter.AnthropicRefusalStopDetails? stopDetails,
            global::OpenRouter.ORAnthropicStopReason? stopReason,
            string? stopSequence,
            global::OpenRouter.BaseMessagesResultType type)
        {
            this.Container = container;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InputTransformations = inputTransformations;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Role = role;
            this.StopDetails = stopDetails;
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
            this.Type = type;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResult" /> class.
        /// </summary>
        public BaseMessagesResult()
        {
        }

    }
}