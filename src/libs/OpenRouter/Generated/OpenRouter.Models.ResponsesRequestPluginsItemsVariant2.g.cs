
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// context-compression variant
    /// </summary>
    public sealed partial class ResponsesRequestPluginsItemsVariant2
    {
        /// <summary>
        /// Discriminator value: context-compression
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant2IdJsonConverter))]
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant2Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the context-compression plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The compression engine to use. Defaults to "middle-out".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContextCompressionEngineJsonConverter))]
        public global::OpenRouter.ContextCompressionEngine? Engine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItemsVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// Discriminator value: context-compression
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable the context-compression plugin for this request. Defaults to true.
        /// </param>
        /// <param name="engine">
        /// The compression engine to use. Defaults to "middle-out".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestPluginsItemsVariant2(
            global::OpenRouter.ResponsesRequestPluginsItemsVariant2Id id,
            bool? enabled,
            global::OpenRouter.ContextCompressionEngine? engine)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.Engine = engine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItemsVariant2" /> class.
        /// </summary>
        public ResponsesRequestPluginsItemsVariant2()
        {
        }
    }
}