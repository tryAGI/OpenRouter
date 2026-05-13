
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An MCP tool call with its output or error
    /// </summary>
    public sealed partial class McpCallItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.McpCallItemTypeJsonConverter))]
        public global::OpenRouter.McpCallItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpCallItem" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="serverLabel"></param>
        /// <param name="error"></param>
        /// <param name="output"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpCallItem(
            string arguments,
            string id,
            string name,
            string serverLabel,
            string? error,
            string? output,
            global::OpenRouter.McpCallItemType type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Error = error;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Output = output;
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpCallItem" /> class.
        /// </summary>
        public McpCallItem()
        {
        }

    }
}