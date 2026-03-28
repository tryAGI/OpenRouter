
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItems1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepJsonConverter))]
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep? Keep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="keep"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestContextManagementEditsItems1(
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Type type,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep? keep)
        {
            this.Type = type;
            this.Keep = keep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems1" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItems1()
        {
        }
    }
}