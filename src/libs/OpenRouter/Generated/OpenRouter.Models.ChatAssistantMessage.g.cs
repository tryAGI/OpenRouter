
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Assistant message for requests and responses<br/>
    /// Example: {"content":"The capital of France is Paris.","model":"openai/gpt-4o","role":"assistant"}
    /// </summary>
    public sealed partial class ChatAssistantMessage
    {
        /// <summary>
        /// Audio output data or reference<br/>
        /// Example: {"data":"UklGRnoGAABXQVZFZm10IBAAAAABAAEAQB8AAEAfAAABAAgAZGF0YQoGAACBhYqFbF1f","expires_at":1677652400,"id":"audio_abc123","transcript":"Hello! How can I help you today?"}
        /// </summary>
        /// <example>{"data":"UklGRnoGAABXQVZFZm10IBAAAAABAAEAQB8AAEAfAAABAAgAZGF0YQoGAACBhYqFbF1f","expires_at":1677652400,"id":"audio_abc123","transcript":"Hello! How can I help you today?"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::OpenRouter.ChatAudioOutput? Audio { get; set; }

        /// <summary>
        /// Assistant message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>>))]
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>>? Content { get; set; }

        /// <summary>
        /// Generated images from image generation models<br/>
        /// Example: [{"image_url":{"url":"data:image/png;base64,iVBORw0KGgo..."}}]
        /// </summary>
        /// <example>[{"image_url":{"url":"data:image/png;base64,iVBORw0KGgo..."}}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatAssistantImage>? Images { get; set; }

        /// <summary>
        /// Model that generated this assistant message<br/>
        /// Example: openai/gpt-4o
        /// </summary>
        /// <example>openai/gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional name for the assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Reasoning output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Reasoning details for extended thinking models<br/>
        /// Example: [{"text":"Let me work through this step by step...","type":"reasoning.text"}]
        /// </summary>
        /// <example>[{"text":"Let me work through this step by step...","type":"reasoning.text"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_details")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>? ReasoningDetails { get; set; }

        /// <summary>
        /// Refusal message if content was refused
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatAssistantMessageRoleJsonConverter))]
        public global::OpenRouter.ChatAssistantMessageRole Role { get; set; }

        /// <summary>
        /// Tool calls made by the assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantMessage" /> class.
        /// </summary>
        /// <param name="audio">
        /// Audio output data or reference<br/>
        /// Example: {"data":"UklGRnoGAABXQVZFZm10IBAAAAABAAEAQB8AAEAfAAABAAgAZGF0YQoGAACBhYqFbF1f","expires_at":1677652400,"id":"audio_abc123","transcript":"Hello! How can I help you today?"}
        /// </param>
        /// <param name="content">
        /// Assistant message content
        /// </param>
        /// <param name="images">
        /// Generated images from image generation models<br/>
        /// Example: [{"image_url":{"url":"data:image/png;base64,iVBORw0KGgo..."}}]
        /// </param>
        /// <param name="model">
        /// Model that generated this assistant message<br/>
        /// Example: openai/gpt-4o
        /// </param>
        /// <param name="name">
        /// Optional name for the assistant
        /// </param>
        /// <param name="reasoning">
        /// Reasoning output
        /// </param>
        /// <param name="reasoningDetails">
        /// Reasoning details for extended thinking models<br/>
        /// Example: [{"text":"Let me work through this step by step...","type":"reasoning.text"}]
        /// </param>
        /// <param name="refusal">
        /// Refusal message if content was refused
        /// </param>
        /// <param name="role"></param>
        /// <param name="toolCalls">
        /// Tool calls made by the assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatAssistantMessage(
            global::OpenRouter.ChatAudioOutput? audio,
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>>? content,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatAssistantImage>? images,
            string? model,
            string? name,
            string? reasoning,
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>? reasoningDetails,
            string? refusal,
            global::OpenRouter.ChatAssistantMessageRole role,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatToolCall>? toolCalls)
        {
            this.Audio = audio;
            this.Content = content;
            this.Images = images;
            this.Model = model;
            this.Name = name;
            this.Reasoning = reasoning;
            this.ReasoningDetails = reasoningDetails;
            this.Refusal = refusal;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAssistantMessage" /> class.
        /// </summary>
        public ChatAssistantMessage()
        {
        }

    }
}