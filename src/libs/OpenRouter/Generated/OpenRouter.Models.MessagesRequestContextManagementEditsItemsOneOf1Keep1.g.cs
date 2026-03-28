
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItemsOneOf1Keep1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf1Keep1" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestContextManagementEditsItemsOneOf1Keep1(
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItemsOneOf1Keep1" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItemsOneOf1Keep1()
        {
        }
    }
}