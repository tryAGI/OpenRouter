#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateEndpointsClient
    {
        /// <summary>
        /// Set private endpoint pricing<br/>
        /// Set the negotiated per-token rates reported for requests routed to this endpoint. Applies to drafts and active endpoints; new rates take effect for subsequent requests. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.PrivateEndpointResponse> UpdatePricingAsync(
            global::System.Guid id,

            global::OpenRouter.UpdatePrivateEndpointPricingRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set private endpoint pricing<br/>
        /// Set the negotiated per-token rates reported for requests routed to this endpoint. Applies to drafts and active endpoints; new rates take effect for subsequent requests. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.PrivateEndpointResponse>> UpdatePricingAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.UpdatePrivateEndpointPricingRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set private endpoint pricing<br/>
        /// Set the negotiated per-token rates reported for requests routed to this endpoint. Applies to drafts and active endpoints; new rates take effect for subsequent requests. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="pricing">
        /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
        /// Example: {"completion":"0.00001","prompt":"0.0000025"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.PrivateEndpointResponse> UpdatePricingAsync(
            global::System.Guid id,
            global::OpenRouter.PrivateEndpointPricing pricing,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}