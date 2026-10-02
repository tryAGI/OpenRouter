
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Interns visible to the authenticated API key.<br/>
    /// Example: {"data":[{"attached_vault_id":null,"created_at":"2026-09-16T08:30:00.000Z","description":"Researches customer questions","hostname":"research-assistant.openrouter.ai","id":"7c9e6679-7425-40de-944b-e07fc1f90ae7","instructions":null,"last_failure_message":null,"model":"openai/gpt-5.4","name":"research-assistant","progress":null,"status":"running","updated_at":"2026-09-16T08:45:00.000Z","vault_id":"b431c59d-6eed-41ac-bc89-9a89be79a121","workspace_id":"89f9f5b2-3f89-4eaf-83ca-5ceae149e8bb"}],"has_more":false}
    /// </summary>
    public sealed partial class InternListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.Intern> Data { get; set; }

        /// <summary>
        /// True when more interns match the current filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Opaque cursor, present when `has_more` is true. Pass it as `starting_after` to fetch the next page.<br/>
        /// Example: MjAyNi0wOS0xNlQwODozMDowMC4wMDAwMDBafDdjOWU2Njc5LTc0MjUtNDBkZS05NDRiLWUwN2ZjMWY5MGFlNw
        /// </summary>
        /// <example>MjAyNi0wOS0xNlQwODozMDowMC4wMDAwMDBafDdjOWU2Njc5LTc0MjUtNDBkZS05NDRiLWUwN2ZjMWY5MGFlNw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore">
        /// True when more interns match the current filters.
        /// </param>
        /// <param name="nextCursor">
        /// Opaque cursor, present when `has_more` is true. Pass it as `starting_after` to fetch the next page.<br/>
        /// Example: MjAyNi0wOS0xNlQwODozMDowMC4wMDAwMDBafDdjOWU2Njc5LTc0MjUtNDBkZS05NDRiLWUwN2ZjMWY5MGFlNw
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternListResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.Intern> data,
            bool hasMore,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternListResponse" /> class.
        /// </summary>
        public InternListResponse()
        {
        }

    }
}