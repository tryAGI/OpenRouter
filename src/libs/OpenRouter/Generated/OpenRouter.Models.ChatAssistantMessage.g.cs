
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Assistant message for requests and responses
    /// </summary>
    public sealed partial class ChatAssistantMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatAssistantMessageRoleJsonConverter))]
        public global::OpenRouter.ChatAssistantMessageRole Role { get; set; }

        /// <summary>
        /// Assistant message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatAssistantMessageContentJsonConverter))]
        public global::OpenRouter.ChatAssistantMessageContent? Content { get; set; }

        /// <summary>
        /// Optional name for the assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tool calls made by the assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Refusal message if content was refused
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// Reasoning output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Reasoning details for extended thinking models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_details")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>? ReasoningDetails { get; set; }

        /// <summary>
        /// Generated images from image generation models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatAssistantImagesItems>? Images { get; set; }

        /// <summary>
        /// Audio output data or reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::OpenRouter.ChatAudioOutput? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content">
        /// Assistant message content
        /// </param>
        /// <param name="name">
        /// Optional name for the assistant
        /// </param>
        /// <param name="toolCalls">
        /// Tool calls made by the assistant
        /// </param>
        /// <param name="refusal">
        /// Refusal message if content was refused
        /// </param>
        /// <param name="reasoning">
        /// Reasoning output
        /// </param>
        /// <param name="reasoningDetails">
        /// Reasoning details for extended thinking models
        /// </param>
        /// <param name="images">
        /// Generated images from image generation models
        /// </param>
        /// <param name="audio">
        /// Audio output data or reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatAssistantMessage(
            global::OpenRouter.ChatAssistantMessageRole role,
            global::OpenRouter.ChatAssistantMessageContent? content,
            string? name,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatToolCall>? toolCalls,
            string? refusal,
            string? reasoning,
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>? reasoningDetails,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatAssistantImagesItems>? images,
            global::OpenRouter.ChatAudioOutput? audio)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
            this.ToolCalls = toolCalls;
            this.Refusal = refusal;
            this.Reasoning = reasoning;
            this.ReasoningDetails = reasoningDetails;
            this.Images = images;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantMessage" /> class.
        /// </summary>
        public ChatAssistantMessage()
        {
        }
    }
}