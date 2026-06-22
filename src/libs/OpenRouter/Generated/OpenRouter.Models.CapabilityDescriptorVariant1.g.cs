
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A supported-or-not flag. Present means the parameter is accepted.
    /// </summary>
    public sealed partial class CapabilityDescriptorVariant1
    {
        /// <summary>
        /// Discriminator value: boolean
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CapabilityDescriptorVariant1TypeJsonConverter))]
        public global::OpenRouter.CapabilityDescriptorVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilityDescriptorVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: boolean
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CapabilityDescriptorVariant1(
            global::OpenRouter.CapabilityDescriptorVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilityDescriptorVariant1" /> class.
        /// </summary>
        public CapabilityDescriptorVariant1()
        {
        }

    }
}