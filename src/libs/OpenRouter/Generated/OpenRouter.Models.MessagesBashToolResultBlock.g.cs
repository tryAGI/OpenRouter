
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Output of a sandbox-executed `openrouter:bash` call from a prior assistant turn. Accepted on replay and dropped before the provider request — Anthropic has no equivalent block.<br/>
    /// Example: {"content":{"command":"ls","exitCode":0,"stderr":"","stdout":"README.md\n"},"tool_use_id":"srvtoolu_01abc","type":"openrouter_bash_tool_result"}
    /// </summary>
    public sealed partial class MessagesBashToolResultBlock
    {
        /// <summary>
        /// The canonical container id the command ran under — the `{container_id}` for the Container Files API, reusable as a `container_reference` in later requests. Present on every sandbox-executed call, even when no files changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        public string? ContainerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

        /// <summary>
        /// Citations for the files the sandbox command created or modified, most-recently-touched first (at most 10). Retrieve them via the Container Files API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesBashToolResultBlockFile>? Files { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesBashToolResultBlockTypeJsonConverter))]
        public global::OpenRouter.MessagesBashToolResultBlockType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesBashToolResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="containerId">
        /// The canonical container id the command ran under — the `{container_id}` for the Container Files API, reusable as a `container_reference` in later requests. Present on every sandbox-executed call, even when no files changed.
        /// </param>
        /// <param name="files">
        /// Citations for the files the sandbox command created or modified, most-recently-touched first (at most 10). Retrieve them via the Container Files API.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesBashToolResultBlock(
            object content,
            string toolUseId,
            string? containerId,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesBashToolResultBlockFile>? files,
            global::OpenRouter.MessagesBashToolResultBlockType type)
        {
            this.ContainerId = containerId;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Files = files;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesBashToolResultBlock" /> class.
        /// </summary>
        public MessagesBashToolResultBlock()
        {
        }

    }
}