
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestPluginsItems5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf5IdJsonConverter))]
        public global::OpenRouter.MessagesRequestPluginsItemsOneOf5Id Id { get; set; }

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
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItems5" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabled">
        /// Set to false to disable the context-compression plugin for this request. Defaults to true.
        /// </param>
        /// <param name="engine">
        /// The compression engine to use. Defaults to "middle-out".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestPluginsItems5(
            global::OpenRouter.MessagesRequestPluginsItemsOneOf5Id id,
            bool? enabled,
            global::OpenRouter.ContextCompressionEngine? engine)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.Engine = engine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItems5" /> class.
        /// </summary>
        public MessagesRequestPluginsItems5()
        {
        }
    }
}