
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// server_tool_use variant
    /// </summary>
    public sealed partial class ORAnthropicContentBlockVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OrAnthropicServerToolUseBlockTypeJsonConverter))]
        public global::OpenRouter.OrAnthropicServerToolUseBlockType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant7" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="caller"></param>
        /// <param name="input"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ORAnthropicContentBlockVariant7(
            string id,
            string name,
            global::OpenRouter.OrAnthropicServerToolUseBlockType type,
            global::OpenRouter.ORAnthropicNullableCaller? caller,
            object? input)
        {
            this.Type = type;
            this.Caller = caller;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Input = input;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ORAnthropicContentBlockVariant7" /> class.
        /// </summary>
        public ORAnthropicContentBlockVariant7()
        {
        }

    }
}