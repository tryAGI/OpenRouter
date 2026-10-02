
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScimSyncJob
    {
        /// <summary>
        /// Time when the sync job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Number of groups deleted, when the job completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_groups")]
        public int? DeletedGroups { get; set; }

        /// <summary>
        /// Stable error message when the job failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Time when synchronization finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public string? FinishedAt { get; set; }

        /// <summary>
        /// Unique identifier for the sync job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Time when synchronization started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// Current status of the sync job: queued, running, succeeded, or failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ScimSyncJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ScimSyncJobStatus Status { get; set; }

        /// <summary>
        /// Number of groups synchronized, when the job completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synced_groups")]
        public int? SyncedGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimSyncJob" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Time when the sync job was created.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the sync job.
        /// </param>
        /// <param name="status">
        /// Current status of the sync job: queued, running, succeeded, or failed.
        /// </param>
        /// <param name="deletedGroups">
        /// Number of groups deleted, when the job completed successfully.
        /// </param>
        /// <param name="errorMessage">
        /// Stable error message when the job failed.
        /// </param>
        /// <param name="finishedAt">
        /// Time when synchronization finished.
        /// </param>
        /// <param name="startedAt">
        /// Time when synchronization started.
        /// </param>
        /// <param name="syncedGroups">
        /// Number of groups synchronized, when the job completed successfully.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScimSyncJob(
            string createdAt,
            global::System.Guid id,
            global::OpenRouter.ScimSyncJobStatus status,
            int? deletedGroups,
            string? errorMessage,
            string? finishedAt,
            string? startedAt,
            int? syncedGroups)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DeletedGroups = deletedGroups;
            this.ErrorMessage = errorMessage;
            this.FinishedAt = finishedAt;
            this.Id = id;
            this.StartedAt = startedAt;
            this.Status = status;
            this.SyncedGroups = syncedGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimSyncJob" /> class.
        /// </summary>
        public ScimSyncJob()
        {
        }

    }
}