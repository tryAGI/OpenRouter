
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The intern's routing table, for the intern's own key only; null for any other caller or when the vault could not build it in time. The keys still list.
    /// </summary>
    public sealed partial class VaultRoutingTable
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_origins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableCustomOrigin> CustomOrigins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultRoutingTableGithub Github { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultRoutingTableGoogle Google { get; set; }

        /// <summary>
        /// Built-in hosts the vault injects a named secret for, and whether that secret is stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host_rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableHostRule> HostRules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_origins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableMcpOrigin> McpOrigins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ReadAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableSecret> Secrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultRoutingTableSlack Slack { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTable" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="customOrigins"></param>
        /// <param name="github"></param>
        /// <param name="google"></param>
        /// <param name="hostRules">
        /// Built-in hosts the vault injects a named secret for, and whether that secret is stored.
        /// </param>
        /// <param name="mcpOrigins"></param>
        /// <param name="readAt"></param>
        /// <param name="secrets"></param>
        /// <param name="slack"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTable(
            string agentId,
            global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableCustomOrigin> customOrigins,
            global::OpenRouter.VaultRoutingTableGithub github,
            global::OpenRouter.VaultRoutingTableGoogle google,
            global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableHostRule> hostRules,
            global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableMcpOrigin> mcpOrigins,
            global::System.DateTime readAt,
            global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableSecret> secrets,
            global::OpenRouter.VaultRoutingTableSlack slack)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CustomOrigins = customOrigins ?? throw new global::System.ArgumentNullException(nameof(customOrigins));
            this.Github = github ?? throw new global::System.ArgumentNullException(nameof(github));
            this.Google = google ?? throw new global::System.ArgumentNullException(nameof(google));
            this.HostRules = hostRules ?? throw new global::System.ArgumentNullException(nameof(hostRules));
            this.McpOrigins = mcpOrigins ?? throw new global::System.ArgumentNullException(nameof(mcpOrigins));
            this.ReadAt = readAt;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.Slack = slack ?? throw new global::System.ArgumentNullException(nameof(slack));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTable" /> class.
        /// </summary>
        public VaultRoutingTable()
        {
        }

    }
}