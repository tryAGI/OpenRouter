
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"excluded_models":["openai/gpt-6-astra"],"id":"jev-router","models":["anthropic/*","openai/gpt-5.6-sol"]}
    /// </summary>
    public sealed partial class JevRouterPlugin
    {
        /// <summary>
        /// Alias of `models`, matching the auto-router field name. Entries from both fields are combined.<br/>
        /// Example: [anthropic/*]
        /// </summary>
        /// <example>[anthropic/*]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Select low, medium, high, or a cost tier configured by the operator. Overrides the live-config tier and replaces the shared routing policy with that tier. Omit to use the live configuration. Model exclusions and the router kill switch still apply.<br/>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_tier")]
        public string? CostTier { get; set; }

        /// <summary>
        /// Remove these models from the router. Each entry is a model slug or a wildcard pattern (e.g. "xiaomi/*"). A `~author/family-latest` alias matches every revision of that family. Up to 1024 patterns, each at most 1024 characters, with 65536 total characters across all patterns. Applied after `models`, so an excluded pattern always wins over an included one; when the lists leave no model the request can use, it fails with 404 rather than routing outside them.<br/>
        /// Example: [openai/gpt-6-astra, xiaomi/*]
        /// </summary>
        /// <example>[openai/gpt-6-astra, xiaomi/*]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_models")]
        public global::System.Collections.Generic.IList<string>? ExcludedModels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.JevRouterPluginIdJsonConverter))]
        public global::OpenRouter.JevRouterPluginId Id { get; set; }

        /// <summary>
        /// Restrict the router to these models. Each entry is a model slug or a wildcard pattern (e.g. "anthropic/*"), matched against the current pool; models outside the pool are ignored. A `~author/family-latest` alias matches every revision of that family. Up to 1024 patterns, each at most 1024 characters, with 65536 total characters across all patterns. When omitted or empty, every model in the pool is a candidate; when no pool model matches, the list is ignored and the whole pool is used (`excluded_models` still apply). `allowed_models` is an alias; entries from both fields are combined.<br/>
        /// Example: [anthropic/*, openai/gpt-5.6-sol]
        /// </summary>
        /// <example>[anthropic/*, openai/gpt-5.6-sol]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JevRouterPlugin" /> class.
        /// </summary>
        /// <param name="allowedModels">
        /// Alias of `models`, matching the auto-router field name. Entries from both fields are combined.<br/>
        /// Example: [anthropic/*]
        /// </param>
        /// <param name="costTier">
        /// Select low, medium, high, or a cost tier configured by the operator. Overrides the live-config tier and replaces the shared routing policy with that tier. Omit to use the live configuration. Model exclusions and the router kill switch still apply.<br/>
        /// Example: medium
        /// </param>
        /// <param name="excludedModels">
        /// Remove these models from the router. Each entry is a model slug or a wildcard pattern (e.g. "xiaomi/*"). A `~author/family-latest` alias matches every revision of that family. Up to 1024 patterns, each at most 1024 characters, with 65536 total characters across all patterns. Applied after `models`, so an excluded pattern always wins over an included one; when the lists leave no model the request can use, it fails with 404 rather than routing outside them.<br/>
        /// Example: [openai/gpt-6-astra, xiaomi/*]
        /// </param>
        /// <param name="id"></param>
        /// <param name="models">
        /// Restrict the router to these models. Each entry is a model slug or a wildcard pattern (e.g. "anthropic/*"), matched against the current pool; models outside the pool are ignored. A `~author/family-latest` alias matches every revision of that family. Up to 1024 patterns, each at most 1024 characters, with 65536 total characters across all patterns. When omitted or empty, every model in the pool is a candidate; when no pool model matches, the list is ignored and the whole pool is used (`excluded_models` still apply). `allowed_models` is an alias; entries from both fields are combined.<br/>
        /// Example: [anthropic/*, openai/gpt-5.6-sol]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JevRouterPlugin(
            global::System.Collections.Generic.IList<string>? allowedModels,
            string? costTier,
            global::System.Collections.Generic.IList<string>? excludedModels,
            global::OpenRouter.JevRouterPluginId id,
            global::System.Collections.Generic.IList<string>? models)
        {
            this.AllowedModels = allowedModels;
            this.CostTier = costTier;
            this.ExcludedModels = excludedModels;
            this.Id = id;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JevRouterPlugin" /> class.
        /// </summary>
        public JevRouterPlugin()
        {
        }

    }
}