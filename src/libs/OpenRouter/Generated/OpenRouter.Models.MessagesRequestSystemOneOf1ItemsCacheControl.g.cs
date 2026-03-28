
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestSystemOneOf1ItemsCacheControl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestSystemOneOf1ItemsCacheControlTypeJsonConverter))]
        public global::OpenRouter.MessagesRequestSystemOneOf1ItemsCacheControlType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestSystemOneOf1ItemsCacheControlTtlJsonConverter))]
        public global::OpenRouter.MessagesRequestSystemOneOf1ItemsCacheControlTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestSystemOneOf1ItemsCacheControl" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ttl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestSystemOneOf1ItemsCacheControl(
            global::OpenRouter.MessagesRequestSystemOneOf1ItemsCacheControlType type,
            global::OpenRouter.MessagesRequestSystemOneOf1ItemsCacheControlTtl? ttl)
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestSystemOneOf1ItemsCacheControl" /> class.
        /// </summary>
        public MessagesRequestSystemOneOf1ItemsCacheControl()
        {
        }
    }
}