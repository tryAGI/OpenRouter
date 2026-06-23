
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskClassificationItem
    {
        /// <summary>
        /// Fraction of this classification's token volume within its macro-category (0–1). Sums to 1 across all classifications sharing the same `macro_category`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_token_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CategoryTokenShare { get; set; }

        /// <summary>
        /// Fraction of this classification's usage within its macro-category (0–1). Sums to 1 across all classifications sharing the same `macro_category`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_usage_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CategoryUsageShare { get; set; }

        /// <summary>
        /// Human-readable label for the classification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Coarse grouping derived from the tag prefix: `code`, `data`, `agent`, or `general`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("macro_category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MacroCategory { get; set; }

        /// <summary>
        /// Top models for this classification by request volume, sorted descending. Each entry reports the model's share of this classification's requests and tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationModel> Models { get; set; }

        /// <summary>
        /// Classification tag identifier (e.g. `code:general_impl`, `agent:web_search`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Fraction of classified sampled token volume (prompt + completion) attributed to this classification (0–1). The unclassified `other` bucket is excluded from the denominator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokenShare { get; set; }

        /// <summary>
        /// Fraction of classified sampled requests attributed to this classification (0–1). The unclassified `other` bucket is excluded from the denominator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageShare { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskClassificationItem" /> class.
        /// </summary>
        /// <param name="categoryTokenShare">
        /// Fraction of this classification's token volume within its macro-category (0–1). Sums to 1 across all classifications sharing the same `macro_category`.
        /// </param>
        /// <param name="categoryUsageShare">
        /// Fraction of this classification's usage within its macro-category (0–1). Sums to 1 across all classifications sharing the same `macro_category`.
        /// </param>
        /// <param name="displayName">
        /// Human-readable label for the classification.
        /// </param>
        /// <param name="macroCategory">
        /// Coarse grouping derived from the tag prefix: `code`, `data`, `agent`, or `general`.
        /// </param>
        /// <param name="models">
        /// Top models for this classification by request volume, sorted descending. Each entry reports the model's share of this classification's requests and tokens.
        /// </param>
        /// <param name="tag">
        /// Classification tag identifier (e.g. `code:general_impl`, `agent:web_search`).
        /// </param>
        /// <param name="tokenShare">
        /// Fraction of classified sampled token volume (prompt + completion) attributed to this classification (0–1). The unclassified `other` bucket is excluded from the denominator.
        /// </param>
        /// <param name="usageShare">
        /// Fraction of classified sampled requests attributed to this classification (0–1). The unclassified `other` bucket is excluded from the denominator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskClassificationItem(
            double categoryTokenShare,
            double categoryUsageShare,
            string displayName,
            string macroCategory,
            global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationModel> models,
            string tag,
            double tokenShare,
            double usageShare)
        {
            this.CategoryTokenShare = categoryTokenShare;
            this.CategoryUsageShare = categoryUsageShare;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.MacroCategory = macroCategory ?? throw new global::System.ArgumentNullException(nameof(macroCategory));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.TokenShare = tokenShare;
            this.UsageShare = usageShare;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskClassificationItem" /> class.
        /// </summary>
        public TaskClassificationItem()
        {
        }

    }
}