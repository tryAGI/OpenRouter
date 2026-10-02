
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The incremental content of one chunk. The first chunk carries `role`, text chunks carry `content`, reasoning chunks carry `reasoning`, and an interaction chunk carries one complete `tool_calls` entry.<br/>
    /// Example: {"content":"Hello"}
    /// </summary>
    public sealed partial class InternChatDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatDeltaRoleJsonConverter))]
        public global::OpenRouter.InternChatDeltaRole? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::OpenRouter.InternChatToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatDelta" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="reasoning"></param>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatDelta(
            string? content,
            string? reasoning,
            global::OpenRouter.InternChatDeltaRole? role,
            global::System.Collections.Generic.IList<global::OpenRouter.InternChatToolCall>? toolCalls)
        {
            this.Content = content;
            this.Reasoning = reasoning;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatDelta" /> class.
        /// </summary>
        public InternChatDelta()
        {
        }

    }
}