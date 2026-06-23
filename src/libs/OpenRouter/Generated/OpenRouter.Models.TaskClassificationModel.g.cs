
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskClassificationModel
    {
        /// <summary>
        /// Model identifier (permaslug).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Fraction of this classification's sampled token volume attributed to this model (0–1). Sums to ≤1 across the returned models (only top-N are included and unattributed requests are excluded).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_token_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TagTokenShare { get; set; }

        /// <summary>
        /// Fraction of this classification's sampled requests attributed to this model (0–1). Sums to ≤1 across the returned models (only top-N are included and unattributed requests are excluded).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_usage_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TagUsageShare { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskClassificationModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Model identifier (permaslug).
        /// </param>
        /// <param name="tagTokenShare">
        /// Fraction of this classification's sampled token volume attributed to this model (0–1). Sums to ≤1 across the returned models (only top-N are included and unattributed requests are excluded).
        /// </param>
        /// <param name="tagUsageShare">
        /// Fraction of this classification's sampled requests attributed to this model (0–1). Sums to ≤1 across the returned models (only top-N are included and unattributed requests are excluded).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskClassificationModel(
            string id,
            double tagTokenShare,
            double tagUsageShare)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TagTokenShare = tagTokenShare;
            this.TagUsageShare = tagUsageShare;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskClassificationModel" /> class.
        /// </summary>
        public TaskClassificationModel()
        {
        }

    }
}