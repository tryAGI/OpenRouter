
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Your declared data policy, or `null` when none was declared.
    /// </summary>
    public sealed partial class PrivateProviderDataPolicy
    {
        /// <summary>
        /// Days prompts are retained. Must be `null` unless `retains_prompts` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_retention_days")]
        public int? PromptRetentionDays { get; set; }

        /// <summary>
        /// Whether the provider retains prompts or completions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retains_prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RetainsPrompts { get; set; }

        /// <summary>
        /// Whether the provider trains on prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Training { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProviderDataPolicy" /> class.
        /// </summary>
        /// <param name="retainsPrompts">
        /// Whether the provider retains prompts or completions.
        /// </param>
        /// <param name="training">
        /// Whether the provider trains on prompts.
        /// </param>
        /// <param name="promptRetentionDays">
        /// Days prompts are retained. Must be `null` unless `retains_prompts` is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateProviderDataPolicy(
            bool retainsPrompts,
            bool training,
            int? promptRetentionDays)
        {
            this.PromptRetentionDays = promptRetentionDays;
            this.RetainsPrompts = retainsPrompts;
            this.Training = training;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProviderDataPolicy" /> class.
        /// </summary>
        public PrivateProviderDataPolicy()
        {
        }

    }
}