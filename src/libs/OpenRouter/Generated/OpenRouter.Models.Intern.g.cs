
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Public lifecycle state and settings for one intern.<br/>
    /// Example: {"attached_vault_id":null,"created_at":"2026-09-16T08:30:00.000Z","description":"Researches customer questions","hostname":"research-assistant.openrouter.ai","id":"7c9e6679-7425-40de-944b-e07fc1f90ae7","instructions":null,"last_failure_message":null,"model":"openai/gpt-5.4","name":"research-assistant","progress":null,"status":"running","updated_at":"2026-09-16T08:45:00.000Z","vault_id":"b431c59d-6eed-41ac-bc89-9a89be79a121","workspace_id":"89f9f5b2-3f89-4eaf-83ca-5ceae149e8bb"}
    /// </summary>
    public sealed partial class Intern
    {
        /// <summary>
        /// Vault the intern borrows from another intern, or null when it borrows none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_vault_id")]
        public string? AttachedVaultId { get; set; }

        /// <summary>
        /// ISO 8601 creation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Free-form description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Public hostname the intern is reachable at, or null until provisioning has assigned one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// Intern id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Standing instructions the intern boots with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Why the last provisioning attempt failed, when status is failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_failure_message")]
        public string? LastFailureMessage { get; set; }

        /// <summary>
        /// OpenRouter model slug the intern runs, or null for the workspace default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Intern name, unique per creator within a workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Active provisioning step, or null once provisioning has settled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::OpenRouter.InternProgress? Progress { get; set; }

        /// <summary>
        /// Lifecycle status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternStatus Status { get; set; }

        /// <summary>
        /// ISO 8601 last update time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Vault the intern owns, or null before it has been created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_id")]
        public string? VaultId { get; set; }

        /// <summary>
        /// Workspace that owns the intern and scopes its secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Intern" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 creation time.
        /// </param>
        /// <param name="id">
        /// Intern id.
        /// </param>
        /// <param name="name">
        /// Intern name, unique per creator within a workspace.
        /// </param>
        /// <param name="status">
        /// Lifecycle status.
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 last update time.
        /// </param>
        /// <param name="workspaceId">
        /// Workspace that owns the intern and scopes its secrets.
        /// </param>
        /// <param name="attachedVaultId">
        /// Vault the intern borrows from another intern, or null when it borrows none.
        /// </param>
        /// <param name="description">
        /// Free-form description.
        /// </param>
        /// <param name="hostname">
        /// Public hostname the intern is reachable at, or null until provisioning has assigned one.
        /// </param>
        /// <param name="instructions">
        /// Standing instructions the intern boots with.
        /// </param>
        /// <param name="lastFailureMessage">
        /// Why the last provisioning attempt failed, when status is failed.
        /// </param>
        /// <param name="model">
        /// OpenRouter model slug the intern runs, or null for the workspace default.
        /// </param>
        /// <param name="progress">
        /// Active provisioning step, or null once provisioning has settled.
        /// </param>
        /// <param name="vaultId">
        /// Vault the intern owns, or null before it has been created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Intern(
            string createdAt,
            string id,
            string name,
            global::OpenRouter.InternStatus status,
            string updatedAt,
            string workspaceId,
            string? attachedVaultId,
            string? description,
            string? hostname,
            string? instructions,
            string? lastFailureMessage,
            string? model,
            global::OpenRouter.InternProgress? progress,
            string? vaultId)
        {
            this.AttachedVaultId = attachedVaultId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description;
            this.Hostname = hostname;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Instructions = instructions;
            this.LastFailureMessage = lastFailureMessage;
            this.Model = model;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Progress = progress;
            this.Status = status;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.VaultId = vaultId;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Intern" /> class.
        /// </summary>
        public Intern()
        {
        }

    }
}