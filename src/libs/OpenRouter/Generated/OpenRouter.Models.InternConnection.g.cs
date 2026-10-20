
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InternConnection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternConnectionAccount Account { get; set; }

        /// <summary>
        /// Stable id: the credential id of an MCP server, else the kind (`slack`, `github`, `google`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the intern reaches it now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// Scoped to this intern rather than shared by the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_intern_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInternOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternConnectionKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternConnectionKind Kind { get; set; }

        /// <summary>
        /// The name the intern's MCP config keys the server by; null when it is not an MCP server or is off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        public string? McpServerName { get; set; }

        /// <summary>
        /// Display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// `switched_off` for this intern, `disabled` for the whole workspace; null while on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("off_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternConnectionOffReasonJsonConverter))]
        public global::OpenRouter.InternConnectionOffReason? OffReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::OpenRouter.InternConnectionServer? Server { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternConnectionStatus Status { get; set; }

        /// <summary>
        /// Tools found by the last successful test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_count")]
        public int? ToolCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternConnection" /> class.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="id">
        /// Stable id: the credential id of an MCP server, else the kind (`slack`, `github`, `google`).
        /// </param>
        /// <param name="isEnabled">
        /// Whether the intern reaches it now.
        /// </param>
        /// <param name="isInternOnly">
        /// Scoped to this intern rather than shared by the workspace.
        /// </param>
        /// <param name="kind"></param>
        /// <param name="name">
        /// Display name.
        /// </param>
        /// <param name="status"></param>
        /// <param name="mcpServerName">
        /// The name the intern's MCP config keys the server by; null when it is not an MCP server or is off.
        /// </param>
        /// <param name="offReason">
        /// `switched_off` for this intern, `disabled` for the whole workspace; null while on.
        /// </param>
        /// <param name="server"></param>
        /// <param name="toolCount">
        /// Tools found by the last successful test.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternConnection(
            global::OpenRouter.InternConnectionAccount account,
            string id,
            bool isEnabled,
            bool isInternOnly,
            global::OpenRouter.InternConnectionKind kind,
            string name,
            global::OpenRouter.InternConnectionStatus status,
            string? mcpServerName,
            global::OpenRouter.InternConnectionOffReason? offReason,
            global::OpenRouter.InternConnectionServer? server,
            int? toolCount)
        {
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsEnabled = isEnabled;
            this.IsInternOnly = isInternOnly;
            this.Kind = kind;
            this.McpServerName = mcpServerName;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OffReason = offReason;
            this.Server = server;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.ToolCount = toolCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternConnection" /> class.
        /// </summary>
        public InternConnection()
        {
        }

    }
}