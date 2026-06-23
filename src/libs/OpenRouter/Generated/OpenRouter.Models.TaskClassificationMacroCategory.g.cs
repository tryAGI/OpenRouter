
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskClassificationMacroCategory
    {
        /// <summary>
        /// Macro-category identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Human-readable label for the macro-category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Combined token share of all classifications in this macro-category (0–1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokenShare { get; set; }

        /// <summary>
        /// Combined usage share of all classifications in this macro-category (0–1).
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
        /// Initializes a new instance of the <see cref="TaskClassificationMacroCategory" /> class.
        /// </summary>
        /// <param name="key">
        /// Macro-category identifier.
        /// </param>
        /// <param name="label">
        /// Human-readable label for the macro-category.
        /// </param>
        /// <param name="tokenShare">
        /// Combined token share of all classifications in this macro-category (0–1).
        /// </param>
        /// <param name="usageShare">
        /// Combined usage share of all classifications in this macro-category (0–1).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskClassificationMacroCategory(
            string key,
            string label,
            double tokenShare,
            double usageShare)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.TokenShare = tokenShare;
            this.UsageShare = usageShare;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskClassificationMacroCategory" /> class.
        /// </summary>
        public TaskClassificationMacroCategory()
        {
        }

    }
}