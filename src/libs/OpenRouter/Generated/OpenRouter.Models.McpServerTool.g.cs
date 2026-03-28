
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// MCP (Model Context Protocol) tool configuration
    /// </summary>
    public sealed partial class McpServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.McpServerToolTypeJsonConverter))]
        public global::OpenRouter.McpServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.McpServerToolAllowedToolsJsonConverter))]
        public global::OpenRouter.McpServerToolAllowedTools? AllowedTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public string? Authorization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.McpServerToolConnectorIdJsonConverter))]
        public global::OpenRouter.McpServerToolConnectorId? ConnectorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApprovalJsonConverter))]
        public global::OpenRouter.McpServerToolRequireApproval? RequireApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_description")]
        public string? ServerDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="serverLabel"></param>
        /// <param name="allowedTools"></param>
        /// <param name="authorization"></param>
        /// <param name="connectorId"></param>
        /// <param name="headers"></param>
        /// <param name="requireApproval"></param>
        /// <param name="serverDescription"></param>
        /// <param name="serverUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerTool(
            string serverLabel,
            global::OpenRouter.McpServerToolType type,
            global::OpenRouter.McpServerToolAllowedTools? allowedTools,
            string? authorization,
            global::OpenRouter.McpServerToolConnectorId? connectorId,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::OpenRouter.McpServerToolRequireApproval? requireApproval,
            string? serverDescription,
            string? serverUrl)
        {
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Type = type;
            this.AllowedTools = allowedTools;
            this.Authorization = authorization;
            this.ConnectorId = connectorId;
            this.Headers = headers;
            this.RequireApproval = requireApproval;
            this.ServerDescription = serverDescription;
            this.ServerUrl = serverUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerTool" /> class.
        /// </summary>
        public McpServerTool()
        {
        }
    }
}