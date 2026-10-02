
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"key":"code","label":"Code","token_share":0.52,"usage_share":0.45}
    /// </summary>
    public sealed partial class TaskClassificationMacroCategory
    {
        /// <summary>
        /// Macro-category identifier.<br/>
        /// Example: code
        /// </summary>
        /// <example>code</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Human-readable label for the macro-category.<br/>
        /// Example: Code
        /// </summary>
        /// <example>Code</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Combined token share of all classifications in this macro-category (0–1).<br/>
        /// Example: 0.52F
        /// </summary>
        /// <example>0.52F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokenShare { get; set; }

        /// <summary>
        /// Combined usage share of all classifications in this macro-category (0–1).<br/>
        /// Example: 0.45F
        /// </summary>
        /// <example>0.45F</example>
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
        /// Macro-category identifier.<br/>
        /// Example: code
        /// </param>
        /// <param name="label">
        /// Human-readable label for the macro-category.<br/>
        /// Example: Code
        /// </param>
        /// <param name="tokenShare">
        /// Combined token share of all classifications in this macro-category (0–1).<br/>
        /// Example: 0.52F
        /// </param>
        /// <param name="usageShare">
        /// Combined usage share of all classifications in this macro-category (0–1).<br/>
        /// Example: 0.45F
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