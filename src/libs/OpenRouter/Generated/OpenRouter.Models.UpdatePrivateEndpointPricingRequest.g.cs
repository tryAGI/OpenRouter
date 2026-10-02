
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePrivateEndpointPricingRequest
    {
        /// <summary>
        /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
        /// Example: {"completion":"0.00001","prompt":"0.0000025"}
        /// </summary>
        /// <example>{"completion":"0.00001","prompt":"0.0000025"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateEndpointPricing Pricing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointPricingRequest" /> class.
        /// </summary>
        /// <param name="pricing">
        /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
        /// Example: {"completion":"0.00001","prompt":"0.0000025"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrivateEndpointPricingRequest(
            global::OpenRouter.PrivateEndpointPricing pricing)
        {
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointPricingRequest" /> class.
        /// </summary>
        public UpdatePrivateEndpointPricingRequest()
        {
        }

    }
}