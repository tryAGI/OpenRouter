
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// moderation variant
    /// </summary>
    public sealed partial class ResponsesRequestPluginsItemsVariant6
    {
        /// <summary>
        /// Discriminator value: moderation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant6IdJsonConverter))]
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant6Id Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItemsVariant6" /> class.
        /// </summary>
        /// <param name="id">
        /// Discriminator value: moderation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestPluginsItemsVariant6(
            global::OpenRouter.ResponsesRequestPluginsItemsVariant6Id id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItemsVariant6" /> class.
        /// </summary>
        public ResponsesRequestPluginsItemsVariant6()
        {
        }

    }
}