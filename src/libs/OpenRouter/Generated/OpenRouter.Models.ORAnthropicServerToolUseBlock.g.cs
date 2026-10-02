
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"caller":{"type":"direct"},"id":"srvtoolu_01abc","input":{},"name":"advisor","type":"server_tool_use"}
    /// </summary>
    public sealed partial class ORAnthropicServerToolUseBlock
    {
        /// <summary>
        /// Example: {"type":"direct"}
        /// </summary>
        /// <example>{"type":"direct"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicNullableCallerJsonConverter))]
        public global::OpenRouter.ORAnthropicNullableCaller? Caller { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ORAnthropicServerToolUseBlockTypeJsonConverter))]
        public global::OpenRouter.ORAnthropicServerToolUseBlockType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicServerToolUseBlock" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="caller">
        /// Example: {"type":"direct"}
        /// </param>
        /// <param name="input"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicServerToolUseBlock(
            string id,
            string name,
            global::OpenRouter.ORAnthropicNullableCaller? caller,
            object? input,
            global::OpenRouter.ORAnthropicServerToolUseBlockType type)
        {
            this.Caller = caller;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Input = input;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicServerToolUseBlock" /> class.
        /// </summary>
        public ORAnthropicServerToolUseBlock()
        {
        }

    }
}