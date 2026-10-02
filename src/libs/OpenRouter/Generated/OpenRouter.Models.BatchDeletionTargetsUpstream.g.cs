
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The upstream batch deletion outcome; omitted when no provider was assigned.
    /// </summary>
    public sealed partial class BatchDeletionTargetsUpstream
    {
        /// <summary>
        /// The provider name stored on the batch.<br/>
        /// Example: OpenAI
        /// </summary>
        /// <example>OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Outcome for one deletion target: `deleted` (removed), `unsupported` (the provider has no batch-delete API; supported file cleanup still runs), or `not_applicable` (the batch never reached that target).<br/>
        /// Example: deleted
        /// </summary>
        /// <example>deleted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchDeletionOutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchDeletionOutcome Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeletionTargetsUpstream" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider name stored on the batch.<br/>
        /// Example: OpenAI
        /// </param>
        /// <param name="status">
        /// Outcome for one deletion target: `deleted` (removed), `unsupported` (the provider has no batch-delete API; supported file cleanup still runs), or `not_applicable` (the batch never reached that target).<br/>
        /// Example: deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDeletionTargetsUpstream(
            string provider,
            global::OpenRouter.BatchDeletionOutcome status)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeletionTargetsUpstream" /> class.
        /// </summary>
        public BatchDeletionTargetsUpstream()
        {
        }

    }
}