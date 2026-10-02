
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProvisionInternResponse
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisioning")]
        public bool Provisioning { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionInternResponse" /> class.
        /// </summary>
        /// <param name="provisioning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProvisionInternResponse(
            bool provisioning = true)
        {
            this.Provisioning = provisioning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionInternResponse" /> class.
        /// </summary>
        public ProvisionInternResponse()
        {
        }

    }
}