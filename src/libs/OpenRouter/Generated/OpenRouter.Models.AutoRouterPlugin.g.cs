
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoRouterPlugin
    {
        /// <summary>
        /// List of model patterns to filter which models the auto-router can route between. Supports wildcards (e.g., "anthropic/*" matches all Anthropic models). When not specified, uses the default supported models list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Set to false to disable the auto-router plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AutoRouterPluginIdJsonConverter))]
        public global::OpenRouter.AutoRouterPluginId Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterPlugin" /> class.
        /// </summary>
        /// <param name="allowedModels">
        /// List of model patterns to filter which models the auto-router can route between. Supports wildcards (e.g., "anthropic/*" matches all Anthropic models). When not specified, uses the default supported models list.
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable the auto-router plugin for this request. Defaults to true.
        /// </param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterPlugin(
            global::System.Collections.Generic.IList<string>? allowedModels,
            bool? enabled,
            global::OpenRouter.AutoRouterPluginId id)
        {
            this.AllowedModels = allowedModels;
            this.Enabled = enabled;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterPlugin" /> class.
        /// </summary>
        public AutoRouterPlugin()
        {
        }
    }
}