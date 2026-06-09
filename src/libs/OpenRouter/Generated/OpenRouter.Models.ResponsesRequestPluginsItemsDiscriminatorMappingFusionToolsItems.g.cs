
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems
    {
        /// <summary>
        /// Optional configuration forwarded as the tool's `parameters` object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Server tool type identifier (e.g. "openrouter:web_search", "openrouter:web_fetch").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems" /> class.
        /// </summary>
        /// <param name="type">
        /// Server tool type identifier (e.g. "openrouter:web_search", "openrouter:web_fetch").
        /// </param>
        /// <param name="parameters">
        /// Optional configuration forwarded as the tool's `parameters` object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems(
            string type,
            object? parameters)
        {
            this.Parameters = parameters;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems" /> class.
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems()
        {
        }

    }
}