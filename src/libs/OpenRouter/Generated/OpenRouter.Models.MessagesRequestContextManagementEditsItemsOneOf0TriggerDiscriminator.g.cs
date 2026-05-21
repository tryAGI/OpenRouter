
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorTypeJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminator(
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminator" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminator()
        {
        }

    }
}