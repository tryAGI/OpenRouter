
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Forces a call to the named MCP server; `name` narrows it to one of its tools<br/>
    /// Example: {"server_label":"huggingface","type":"mcp"}
    /// </summary>
    public sealed partial class ToolChoiceMcp
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolChoiceMcpTypeJsonConverter))]
        public global::OpenRouter.ToolChoiceMcpType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceMcp" /> class.
        /// </summary>
        /// <param name="serverLabel"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceMcp(
            string serverLabel,
            string? name,
            global::OpenRouter.ToolChoiceMcpType type)
        {
            this.Name = name;
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceMcp" /> class.
        /// </summary>
        public ToolChoiceMcp()
        {
        }

    }
}