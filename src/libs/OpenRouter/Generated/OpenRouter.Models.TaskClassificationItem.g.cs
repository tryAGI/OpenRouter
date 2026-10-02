
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"category_token_share":0.48,"category_usage_share":0.51,"display_name":"Code Generation","macro_category":"code","models":[{"id":"openai/gpt-4.1-mini","tag_token_share":0.75,"tag_usage_share":0.55},{"id":"anthropic/claude-sonnet-4","tag_token_share":0.12,"tag_usage_share":0.2}],"tag":"code:general_impl","token_share":0.31,"usage_share":0.23}
    /// </summary>
    public sealed partial class TaskClassificationItem
    {
        /// <summary>
        /// Fraction of this classification's token volume within its macro-category (0–1). Sums to 1 across all classifications sharing the same `macro_category`.<br/>
        /// Example: 0.48F
        /// </summary>
        /// <example>0.48F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_token_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CategoryTokenShare { get; set; }

        /// <summary>
        /// Fraction of this classification's usage within its macro-category (0–1). Sums to 1 across all classifications sharing the same `macro_category`.<br/>
        /// Example: 0.51F
        /// </summary>
        /// <example>0.51F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_usage_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CategoryUsageShare { get; set; }

        /// <summary>
        /// Human-readable label for the classification.<br/>
        /// Example: Code Generation
        /// </summary>
        /// <example>Code Generation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Coarse grouping derived from the tag prefix: `code`, `data`, `agent`, or `general`.<br/>
        /// Example: code
        /// </summary>
        /// <example>code</example>
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
        /// Classification tag identifier (e.g. `code:general_impl`, `agent:web_search`).<br/>
        /// Example: code:general_impl
        /// </summary>
        /// <example>code:general_impl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Fraction of classified sampled token volume (prompt + completion) attributed to this classification (0–1). The unclassified `other` bucket is excluded from the denominator.<br/>
        /// Example: 0.31F
        /// </summary>
        /// <example>0.31F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokenShare { get; set; }

        /// <summary>
        /// Fraction of classified sampled requests attributed to this classification (0–1). The unclassified `other` bucket is excluded from the denominator.<br/>
        /// Example: 0.23F
        /// </summary>
        /// <example>0.23F</example>
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
        /// Fraction of this classification's token volume within its macro-category (0–1). Sums to 1 across all classifications sharing the same `macro_category`.<br/>
        /// Example: 0.48F
        /// </param>
        /// <param name="categoryUsageShare">
        /// Fraction of this classification's usage within its macro-category (0–1). Sums to 1 across all classifications sharing the same `macro_category`.<br/>
        /// Example: 0.51F
        /// </param>
        /// <param name="displayName">
        /// Human-readable label for the classification.<br/>
        /// Example: Code Generation
        /// </param>
        /// <param name="macroCategory">
        /// Coarse grouping derived from the tag prefix: `code`, `data`, `agent`, or `general`.<br/>
        /// Example: code
        /// </param>
        /// <param name="models">
        /// Top models for this classification by request volume, sorted descending. Each entry reports the model's share of this classification's requests and tokens.
        /// </param>
        /// <param name="tag">
        /// Classification tag identifier (e.g. `code:general_impl`, `agent:web_search`).<br/>
        /// Example: code:general_impl
        /// </param>
        /// <param name="tokenShare">
        /// Fraction of classified sampled token volume (prompt + completion) attributed to this classification (0–1). The unclassified `other` bucket is excluded from the denominator.<br/>
        /// Example: 0.31F
        /// </param>
        /// <param name="usageShare">
        /// Fraction of classified sampled requests attributed to this classification (0–1). The unclassified `other` bucket is excluded from the denominator.<br/>
        /// Example: 0.23F
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