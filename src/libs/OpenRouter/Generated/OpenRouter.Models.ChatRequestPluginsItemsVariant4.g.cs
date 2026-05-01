
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// moderation variant
    /// </summary>
    public sealed partial class ChatRequestPluginsItemsVariant4
    {
        /// <summary>
        /// Discriminator value: moderation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant4IdJsonConverter))]
        public global::OpenRouter.ChatRequestPluginsItemsVariant4Id Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItemsVariant4" /> class.
        /// </summary>
        /// <param name="id">
        /// Discriminator value: moderation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestPluginsItemsVariant4(
            global::OpenRouter.ChatRequestPluginsItemsVariant4Id id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestPluginsItemsVariant4" /> class.
        /// </summary>
        public ChatRequestPluginsItemsVariant4()
        {
        }
    }
}