
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Tool call delta for streaming responses<br/>
    /// Example: {"function":{"arguments":"{\u0022location\u0022: \u0022...\u0022}","name":"get_weather"},"id":"call_abc123","index":0,"type":"function"}
    /// </summary>
    public sealed partial class ChatStreamToolCall
    {
        /// <summary>
        /// Function call details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::OpenRouter.ChatStreamToolCallFunction? Function { get; set; }

        /// <summary>
        /// Tool call identifier<br/>
        /// Example: call_abc123
        /// </summary>
        /// <example>call_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Tool call index in the array<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Tool call type<br/>
        /// Example: function
        /// </summary>
        /// <example>function</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatStreamToolCallTypeJsonConverter))]
        public global::OpenRouter.ChatStreamToolCallType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamToolCall" /> class.
        /// </summary>
        /// <param name="index">
        /// Tool call index in the array<br/>
        /// Example: 0
        /// </param>
        /// <param name="function">
        /// Function call details
        /// </param>
        /// <param name="id">
        /// Tool call identifier<br/>
        /// Example: call_abc123
        /// </param>
        /// <param name="type">
        /// Tool call type<br/>
        /// Example: function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamToolCall(
            int index,
            global::OpenRouter.ChatStreamToolCallFunction? function,
            string? id,
            global::OpenRouter.ChatStreamToolCallType? type)
        {
            this.Function = function;
            this.Id = id;
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamToolCall" /> class.
        /// </summary>
        public ChatStreamToolCall()
        {
        }

    }
}