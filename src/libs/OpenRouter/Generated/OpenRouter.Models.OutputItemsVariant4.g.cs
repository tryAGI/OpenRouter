
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// message variant
    /// </summary>
    public sealed partial class OutputItemsVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputMessageTypeJsonConverter))]
        public global::OpenRouter.OutputMessageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OutputMessageContentItems> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputMessagePhaseJsonConverter))]
        public global::OpenRouter.OutputMessagePhase? Phase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputMessageRoleJsonConverter))]
        public global::OpenRouter.OutputMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputMessageStatusJsonConverter))]
        public global::OpenRouter.OutputMessageStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant4" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="phase">
        /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
        /// </param>
        /// <param name="role"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant4(
            global::System.Collections.Generic.IList<global::OpenRouter.OutputMessageContentItems> content,
            string id,
            global::OpenRouter.OutputMessageType type,
            global::OpenRouter.OutputMessagePhase? phase,
            global::OpenRouter.OutputMessageRole role,
            global::OpenRouter.OutputMessageStatus? status)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Phase = phase;
            this.Role = role;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant4" /> class.
        /// </summary>
        public OutputItemsVariant4()
        {
        }
    }
}