
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomToolCallOutputItemOutputOneOf1ItemsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorTypeJsonConverter))]
        public global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolCallOutputItemOutputOneOf1ItemsDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolCallOutputItemOutputOneOf1ItemsDiscriminator(
            global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolCallOutputItemOutputOneOf1ItemsDiscriminator" /> class.
        /// </summary>
        public CustomToolCallOutputItemOutputOneOf1ItemsDiscriminator()
        {
        }
    }
}