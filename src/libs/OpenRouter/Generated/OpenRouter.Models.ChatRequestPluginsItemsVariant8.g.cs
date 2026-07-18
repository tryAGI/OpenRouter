
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// response-healing variant
    /// </summary>
    public sealed partial class ChatRequestPluginsItemsVariant8
    {
        /// <summary>
        /// Discriminator value: response-healing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant8IdJsonConverter))]
        public global::OpenRouter.ChatRequestPluginsItemsVariant8Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the response-healing plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItemsVariant8" /> class.
        /// </summary>
        /// <param name="id">
        /// Discriminator value: response-healing
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable the response-healing plugin for this request. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestPluginsItemsVariant8(
            global::OpenRouter.ChatRequestPluginsItemsVariant8Id id,
            bool? enabled)
        {
            this.Id = id;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItemsVariant8" /> class.
        /// </summary>
        public ChatRequestPluginsItemsVariant8()
        {
        }

    }
}