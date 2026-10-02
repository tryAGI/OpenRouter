
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter cleanup and, when a provider was assigned, the upstream batch deletion outcome.<br/>
    /// Example: {"openrouter":"deleted","upstream":{"provider":"Anthropic","status":"deleted"}}
    /// </summary>
    public sealed partial class BatchDeletionTargets
    {
        /// <summary>
        /// OpenRouter-held request and result artifacts were purged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchDeletionTargetsOpenrouterJsonConverter))]
        public global::OpenRouter.BatchDeletionTargetsOpenrouter Openrouter { get; set; }

        /// <summary>
        /// The upstream batch deletion outcome; omitted when no provider was assigned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream")]
        public global::OpenRouter.BatchDeletionTargetsUpstream? Upstream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeletionTargets" /> class.
        /// </summary>
        /// <param name="openrouter">
        /// OpenRouter-held request and result artifacts were purged.
        /// </param>
        /// <param name="upstream">
        /// The upstream batch deletion outcome; omitted when no provider was assigned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDeletionTargets(
            global::OpenRouter.BatchDeletionTargetsOpenrouter openrouter,
            global::OpenRouter.BatchDeletionTargetsUpstream? upstream)
        {
            this.Openrouter = openrouter;
            this.Upstream = upstream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeletionTargets" /> class.
        /// </summary>
        public BatchDeletionTargets()
        {
        }

    }
}