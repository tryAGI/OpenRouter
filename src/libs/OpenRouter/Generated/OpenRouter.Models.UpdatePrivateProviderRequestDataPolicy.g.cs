
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePrivateProviderRequestDataPolicy
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
        public bool? RetainsPrompts { get; set; }

        /// <summary>
        /// Whether the provider trains on prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training")]
        public bool? Training { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateProviderRequestDataPolicy" /> class.
        /// </summary>
        /// <param name="promptRetentionDays">
        /// Days prompts are retained. Must be `null` unless `retains_prompts` is true.
        /// </param>
        /// <param name="retainsPrompts">
        /// Whether the provider retains prompts or completions.
        /// </param>
        /// <param name="training">
        /// Whether the provider trains on prompts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrivateProviderRequestDataPolicy(
            int? promptRetentionDays,
            bool? retainsPrompts,
            bool? training)
        {
            this.PromptRetentionDays = promptRetentionDays;
            this.RetainsPrompts = retainsPrompts;
            this.Training = training;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateProviderRequestDataPolicy" /> class.
        /// </summary>
        public UpdatePrivateProviderRequestDataPolicy()
        {
        }

    }
}