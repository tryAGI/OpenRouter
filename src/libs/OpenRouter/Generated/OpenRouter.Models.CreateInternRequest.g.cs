
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Settings for a new intern.<br/>
    /// Example: {"name":"research-assistant","provision":true,"workspace_id":"89f9f5b2-3f89-4eaf-83ca-5ceae149e8bb"}
    /// </summary>
    public sealed partial class CreateInternRequest
    {
        /// <summary>
        /// Free-form description, or null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Standing instructions the intern boots with, or null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Intern name, unique per creator within the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Start provisioning during this create operation. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provision")]
        public bool? Provision { get; set; }

        /// <summary>
        /// Vault owned by another intern in this workspace to attach as a borrowed vault.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_id")]
        public global::System.Guid? VaultId { get; set; }

        /// <summary>
        /// Workspace that will own the intern. Defaults to the workspace the API key resolves to. When given, it must match the API key workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInternRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Intern name, unique per creator within the workspace.
        /// </param>
        /// <param name="description">
        /// Free-form description, or null.
        /// </param>
        /// <param name="instructions">
        /// Standing instructions the intern boots with, or null.
        /// </param>
        /// <param name="provision">
        /// Start provisioning during this create operation. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="vaultId">
        /// Vault owned by another intern in this workspace to attach as a borrowed vault.
        /// </param>
        /// <param name="workspaceId">
        /// Workspace that will own the intern. Defaults to the workspace the API key resolves to. When given, it must match the API key workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInternRequest(
            string name,
            string? description,
            string? instructions,
            bool? provision,
            global::System.Guid? vaultId,
            global::System.Guid? workspaceId)
        {
            this.Description = description;
            this.Instructions = instructions;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provision = provision;
            this.VaultId = vaultId;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInternRequest" /> class.
        /// </summary>
        public CreateInternRequest()
        {
        }

    }
}