
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for a remote MCP server tool.<br/>
    /// Example: {"server_label":"huggingface","server_url":"https://huggingface.co/mcp"}
    /// </summary>
    public sealed partial class McpServerToolParameters
    {
        /// <summary>
        /// Restrict the tools exposed to the model to this list or filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::OpenRouter.McpServerToolParametersAllowedTools>))]
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<string>, global::OpenRouter.McpServerToolParametersAllowedTools>? AllowedTools { get; set; }

        /// <summary>
        /// OAuth access token sent as the Authorization bearer to the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public string? Authorization { get; set; }

        /// <summary>
        /// Provider-defined connector identifier, forwarded as written to providers that run MCP themselves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// Extra headers sent on every request to the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Approval policy for tool calls. Defaults to always: a call that needs approval ends the response with an mcp_approval_request item, answered with an mcp_approval_response on the next request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.McpServerToolParametersRequireApprovalVariant1, global::OpenRouter.McpServerToolParametersRequireApprovalVariant2?, global::OpenRouter.McpServerToolParametersRequireApprovalVariant3?>))]
        public global::OpenRouter.AnyOf<global::OpenRouter.McpServerToolParametersRequireApprovalVariant1, global::OpenRouter.McpServerToolParametersRequireApprovalVariant2?, global::OpenRouter.McpServerToolParametersRequireApprovalVariant3?>? RequireApproval { get; set; }

        /// <summary>
        /// Extra context about the server, shown to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_description")]
        public string? ServerDescription { get; set; }

        /// <summary>
        /// Label for this MCP server, used in mcp_list_tools and mcp_call items.<br/>
        /// Example: huggingface
        /// </summary>
        /// <example>huggingface</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// URL of the remote MCP server (streamable HTTP).<br/>
        /// Example: https://huggingface.co/mcp
        /// </summary>
        /// <example>https://huggingface.co/mcp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolParameters" /> class.
        /// </summary>
        /// <param name="serverLabel">
        /// Label for this MCP server, used in mcp_list_tools and mcp_call items.<br/>
        /// Example: huggingface
        /// </param>
        /// <param name="allowedTools">
        /// Restrict the tools exposed to the model to this list or filter.
        /// </param>
        /// <param name="authorization">
        /// OAuth access token sent as the Authorization bearer to the server.
        /// </param>
        /// <param name="connectorId">
        /// Provider-defined connector identifier, forwarded as written to providers that run MCP themselves.
        /// </param>
        /// <param name="headers">
        /// Extra headers sent on every request to the server.
        /// </param>
        /// <param name="requireApproval">
        /// Approval policy for tool calls. Defaults to always: a call that needs approval ends the response with an mcp_approval_request item, answered with an mcp_approval_response on the next request.
        /// </param>
        /// <param name="serverDescription">
        /// Extra context about the server, shown to the model.
        /// </param>
        /// <param name="serverUrl">
        /// URL of the remote MCP server (streamable HTTP).<br/>
        /// Example: https://huggingface.co/mcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerToolParameters(
            string serverLabel,
            global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<string>, global::OpenRouter.McpServerToolParametersAllowedTools>? allowedTools,
            string? authorization,
            string? connectorId,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::OpenRouter.AnyOf<global::OpenRouter.McpServerToolParametersRequireApprovalVariant1, global::OpenRouter.McpServerToolParametersRequireApprovalVariant2?, global::OpenRouter.McpServerToolParametersRequireApprovalVariant3?>? requireApproval,
            string? serverDescription,
            string? serverUrl)
        {
            this.AllowedTools = allowedTools;
            this.Authorization = authorization;
            this.ConnectorId = connectorId;
            this.Headers = headers;
            this.RequireApproval = requireApproval;
            this.ServerDescription = serverDescription;
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.ServerUrl = serverUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolParameters" /> class.
        /// </summary>
        public McpServerToolParameters()
        {
        }

    }
}