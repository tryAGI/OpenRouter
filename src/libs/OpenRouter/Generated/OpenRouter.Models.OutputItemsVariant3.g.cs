
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A call to a custom (freeform-grammar) tool created by the model — distinct from `function_call`. Used for tools like Codex CLI's `apply_patch` whose payload is opaque text rather than JSON arguments.
    /// </summary>
    public sealed partial class OutputItemsVariant3
    {
        /// <summary>
        /// Discriminator value: custom_tool_call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsVariant3TypeJsonConverter))]
        public global::OpenRouter.OutputItemsVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Namespace qualifier for tools registered as part of a namespace tool group (e.g. an MCP server)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant3" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="input"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Discriminator value: custom_tool_call
        /// </param>
        /// <param name="id"></param>
        /// <param name="namespace">
        /// Namespace qualifier for tools registered as part of a namespace tool group (e.g. an MCP server)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant3(
            string callId,
            string input,
            string name,
            global::OpenRouter.OutputItemsVariant3Type type,
            string? id,
            string? @namespace)
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Namespace = @namespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant3" /> class.
        /// </summary>
        public OutputItemsVariant3()
        {
        }

    }
}