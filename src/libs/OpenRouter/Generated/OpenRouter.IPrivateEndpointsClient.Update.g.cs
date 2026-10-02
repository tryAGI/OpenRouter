#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateEndpointsClient
    {
        /// <summary>
        /// Update a draft private endpoint<br/>
        /// Replace a draft endpoint's upstream configuration: send `upstream_model_id`, and `base_url` to change it (an omitted `base_url` keeps the stored one). Omitted data-policy declarations are kept while the upstream is unchanged and cleared when it changes. Any change clears earlier validation. Active endpoints return 409; delete and re-create them instead. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.PrivateEndpointResponse> UpdateAsync(
            global::System.Guid id,

            global::OpenRouter.UpdatePrivateEndpointRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a draft private endpoint<br/>
        /// Replace a draft endpoint's upstream configuration: send `upstream_model_id`, and `base_url` to change it (an omitted `base_url` keeps the stored one). Omitted data-policy declarations are kept while the upstream is unchanged and cleared when it changes. Any change clears earlier validation. Active endpoints return 409; delete and re-create them instead. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.PrivateEndpointResponse>> UpdateAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.UpdatePrivateEndpointRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a draft private endpoint<br/>
        /// Replace a draft endpoint's upstream configuration: send `upstream_model_id`, and `base_url` to change it (an omitted `base_url` keeps the stored one). Omitted data-policy declarations are kept while the upstream is unchanged and cleared when it changes. Any change clears earlier validation. Active endpoints return 409; delete and re-create them instead. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="baseUrl">
        /// HTTPS base URL of your deployment. Required unless the provider derives its URL from the BYOK credential (Azure, Amazon Bedrock, Google Vertex).<br/>
        /// Example: https://contoso.openai.azure.com
        /// </param>
        /// <param name="declaredRegion">
        /// Attest where this deployment processes data.<br/>
        /// Example: us
        /// </param>
        /// <param name="declaredZdr">
        /// Attest that this deployment retains no prompt or completion data.
        /// </param>
        /// <param name="upstreamModelId">
        /// Model or deployment identifier sent to the upstream provider.<br/>
        /// Example: gpt-4o-prod
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.PrivateEndpointResponse> UpdateAsync(
            global::System.Guid id,
            string upstreamModelId,
            string? baseUrl = default,
            global::OpenRouter.UpdatePrivateEndpointRequestDeclaredRegion? declaredRegion = default,
            bool? declaredZdr = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}