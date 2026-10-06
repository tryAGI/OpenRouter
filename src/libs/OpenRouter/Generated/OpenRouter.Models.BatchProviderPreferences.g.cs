
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Batch provider routing preferences. Only `provider.only` and `provider.allow_fallbacks` are supported.<br/>
    /// Example: {"only":["google-vertex"]}
    /// </summary>
    public sealed partial class BatchProviderPreferences
    {
        /// <summary>
        /// Whether to allow backup providers to serve requests<br/>
        /// - true: (default) when the primary provider (or your custom providers in "order") is unavailable, use the next best provider.<br/>
        /// - false: use only the primary/custom provider, and return the upstream error if it's unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_fallbacks")]
        public bool? AllowFallbacks { get; set; }

        /// <summary>
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </summary>
        /// <example>[openai, anthropic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("only")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Only { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchProviderPreferences" /> class.
        /// </summary>
        /// <param name="allowFallbacks">
        /// Whether to allow backup providers to serve requests<br/>
        /// - true: (default) when the primary provider (or your custom providers in "order") is unavailable, use the next best provider.<br/>
        /// - false: use only the primary/custom provider, and return the upstream error if it's unavailable.
        /// </param>
        /// <param name="only">
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchProviderPreferences(
            bool? allowFallbacks,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? only)
        {
            this.AllowFallbacks = allowFallbacks;
            this.Only = only;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchProviderPreferences" /> class.
        /// </summary>
        public BatchProviderPreferences()
        {
        }

    }
}