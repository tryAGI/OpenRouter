
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Request for approval to execute an MCP tool
    /// </summary>
    public sealed partial class McpApprovalRequestItem
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
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.McpApprovalRequestItemTypeJsonConverter))]
        public global::OpenRouter.McpApprovalRequestItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalRequestItem" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="serverLabel"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpApprovalRequestItem(
            string arguments,
            string id,
            string name,
            string serverLabel,
            global::OpenRouter.McpApprovalRequestItemType type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpApprovalRequestItem" /> class.
        /// </summary>
        public McpApprovalRequestItem()
        {
        }

    }
}