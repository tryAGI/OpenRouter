
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContainerNetworkPolicyVariant1
    {
        /// <summary>
        /// No outbound internet access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContainerNetworkPolicyVariant1TypeJsonConverter))]
        public global::OpenRouter.ContainerNetworkPolicyVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerNetworkPolicyVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// No outbound internet access.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerNetworkPolicyVariant1(
            global::OpenRouter.ContainerNetworkPolicyVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerNetworkPolicyVariant1" /> class.
        /// </summary>
        public ContainerNetworkPolicyVariant1()
        {
        }

    }
}