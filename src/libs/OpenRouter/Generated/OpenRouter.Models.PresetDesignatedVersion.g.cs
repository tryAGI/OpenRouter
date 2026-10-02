
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A specific version of a preset, containing config and optional system prompt.<br/>
    /// Example: {"config":{"model":"openai/gpt-4o","temperature":0.7},"created_at":"2026-04-20T10:00:00Z","creator_id":"user_2dHFtVWx2n56w6HkM0000000000","id":"550e8400-e29b-41d4-a716-446655440000","preset_id":"650e8400-e29b-41d4-a716-446655440001","system_prompt":"You are a helpful assistant.","updated_at":"2026-04-20T10:00:00Z","version":1}
    /// </summary>
    public sealed partial class PresetDesignatedVersion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetDesignatedVersion" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="createdAt"></param>
        /// <param name="creatorId"></param>
        /// <param name="id"></param>
        /// <param name="presetId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="version"></param>
        /// <param name="systemPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresetDesignatedVersion(
            object config,
            string createdAt,
            string creatorId,
            string id,
            string presetId,
            string updatedAt,
            int version,
            string? systemPrompt)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatorId = creatorId ?? throw new global::System.ArgumentNullException(nameof(creatorId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PresetId = presetId ?? throw new global::System.ArgumentNullException(nameof(presetId));
            this.SystemPrompt = systemPrompt;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetDesignatedVersion" /> class.
        /// </summary>
        public PresetDesignatedVersion()
        {
        }

    }
}