
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// tool_uses variant
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2
    {
        /// <summary>
        /// Discriminator value: tool_uses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type">
        /// Discriminator value: tool_uses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2(
            int value,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2()
        {
        }
    }
}