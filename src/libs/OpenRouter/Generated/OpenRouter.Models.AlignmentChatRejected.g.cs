
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The assistant message of the withheld turn, without reasoning. `audio` holds the id and transcript of the audio, without `data` or `expires_at`.<br/>
    /// Example: {"content":"Sure, I can take 20% off your order.","refusal":null,"role":"assistant"}
    /// </summary>
    public sealed partial class AlignmentChatRejected
    {
        /// <summary>
        /// The audio of the withheld message: its `id` and `transcript`. The plugin does not retain `data` or `expires_at`.<br/>
        /// Example: {"id":"audio_abc123","transcript":"Sure, I can take 20% off your order."}
        /// </summary>
        /// <example>{"id":"audio_abc123","transcript":"Sure, I can take 20% off your order."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::OpenRouter.AlignmentChatAudio? Audio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentChatImage>? Images { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AlignmentChatRejectedRoleJsonConverter))]
        public global::OpenRouter.AlignmentChatRejectedRole Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentChatToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentChatRejected" /> class.
        /// </summary>
        /// <param name="audio">
        /// The audio of the withheld message: its `id` and `transcript`. The plugin does not retain `data` or `expires_at`.<br/>
        /// Example: {"id":"audio_abc123","transcript":"Sure, I can take 20% off your order."}
        /// </param>
        /// <param name="content"></param>
        /// <param name="images"></param>
        /// <param name="refusal"></param>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlignmentChatRejected(
            global::OpenRouter.AlignmentChatAudio? audio,
            string? content,
            global::System.Collections.Generic.IList<global::OpenRouter.AlignmentChatImage>? images,
            string? refusal,
            global::OpenRouter.AlignmentChatRejectedRole role,
            global::System.Collections.Generic.IList<global::OpenRouter.AlignmentChatToolCall>? toolCalls)
        {
            this.Audio = audio;
            this.Content = content;
            this.Images = images;
            this.Refusal = refusal;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentChatRejected" /> class.
        /// </summary>
        public AlignmentChatRejected()
        {
        }

    }
}