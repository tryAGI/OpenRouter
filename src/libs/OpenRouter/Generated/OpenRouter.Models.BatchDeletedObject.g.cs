
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Confirms a terminal batch was removed from the API and its OpenRouter-held artifacts purged. Deletion is not cancellation and does not erase billing or audit records.<br/>
    /// Example: {"deletion":{"openrouter":"deleted","upstream":{"provider":"OpenAI","status":"unsupported"}},"id":"batch_abc123","object":"batch"}
    /// </summary>
    public sealed partial class BatchDeletedObject
    {
        /// <summary>
        /// OpenRouter cleanup and, when a provider was assigned, the upstream batch deletion outcome.<br/>
        /// Example: {"openrouter":"deleted","upstream":{"provider":"Anthropic","status":"deleted"}}
        /// </summary>
        /// <example>{"openrouter":"deleted","upstream":{"provider":"Anthropic","status":"deleted"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchDeletionTargets Deletion { get; set; }

        /// <summary>
        /// Example: batch_abc123
        /// </summary>
        /// <example>batch_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchDeletedObjectObjectJsonConverter))]
        public global::OpenRouter.BatchDeletedObjectObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeletedObject" /> class.
        /// </summary>
        /// <param name="deletion">
        /// OpenRouter cleanup and, when a provider was assigned, the upstream batch deletion outcome.<br/>
        /// Example: {"openrouter":"deleted","upstream":{"provider":"Anthropic","status":"deleted"}}
        /// </param>
        /// <param name="id">
        /// Example: batch_abc123
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDeletedObject(
            global::OpenRouter.BatchDeletionTargets deletion,
            string id,
            global::OpenRouter.BatchDeletedObjectObject @object)
        {
            this.Deletion = deletion ?? throw new global::System.ArgumentNullException(nameof(deletion));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeletedObject" /> class.
        /// </summary>
        public BatchDeletedObject()
        {
        }

    }
}