
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image input content item
    /// </summary>
    public sealed partial class AgentMessageItemContentItems1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AgentMessageItemContentItemsOneOf1DetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AgentMessageItemContentItemsOneOf1Detail Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AgentMessageItemContentItemsOneOf1TypeJsonConverter))]
        public global::OpenRouter.AgentMessageItemContentItemsOneOf1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessageItemContentItems1" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMessageItemContentItems1(
            global::OpenRouter.AgentMessageItemContentItemsOneOf1Detail detail,
            string? imageUrl,
            global::OpenRouter.AgentMessageItemContentItemsOneOf1Type type)
        {
            this.Detail = detail;
            this.ImageUrl = imageUrl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessageItemContentItems1" /> class.
        /// </summary>
        public AgentMessageItemContentItems1()
        {
        }

    }
}