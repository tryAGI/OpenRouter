#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateEndpointsClient
    {
        /// <summary>
        /// Create a private endpoint<br/>
        /// Create a private endpoint as a draft. Drafts are not routable: validate one with `POST /private-endpoints/{id}/validate`, then activate it with `POST /private-endpoints/{id}/activate`. Pass `activate` to do all three in one call; if validation fails the draft is kept and returned with the failed checks. Send an `Idempotency-Key` header to make retries safe: a repeated key with the same request returns the endpoint the first request created; reusing it with different fields returns 422 `idempotency_key_reused`. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Retry-safe create: a repeated create with the same key from the same organization returns the endpoint the first request created instead of creating another. The endpoint is returned as it is now. Reusing a key with a different request body (model, provider, base URL, upstream model ID, declared ZDR or region, or pricing) is rejected with 422 `idempotency_key_reused`. `activate` is not compared, and later edits to the endpoint do not affect the comparison.<br/>
        /// Example: wayfair-gpt-4o-eastus-2026-09
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ManagedPrivateEndpointResponse> CreateAsync(

            global::OpenRouter.CreatePrivateEndpointRequest request,
            string? idempotencyKey = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a private endpoint<br/>
        /// Create a private endpoint as a draft. Drafts are not routable: validate one with `POST /private-endpoints/{id}/validate`, then activate it with `POST /private-endpoints/{id}/activate`. Pass `activate` to do all three in one call; if validation fails the draft is kept and returned with the failed checks. Send an `Idempotency-Key` header to make retries safe: a repeated key with the same request returns the endpoint the first request created; reusing it with different fields returns 422 `idempotency_key_reused`. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Retry-safe create: a repeated create with the same key from the same organization returns the endpoint the first request created instead of creating another. The endpoint is returned as it is now. Reusing a key with a different request body (model, provider, base URL, upstream model ID, declared ZDR or region, or pricing) is rejected with 422 `idempotency_key_reused`. `activate` is not compared, and later edits to the endpoint do not affect the comparison.<br/>
        /// Example: wayfair-gpt-4o-eastus-2026-09
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ManagedPrivateEndpointResponse>> CreateAsResponseAsync(

            global::OpenRouter.CreatePrivateEndpointRequest request,
            string? idempotencyKey = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a private endpoint<br/>
        /// Create a private endpoint as a draft. Drafts are not routable: validate one with `POST /private-endpoints/{id}/validate`, then activate it with `POST /private-endpoints/{id}/activate`. Pass `activate` to do all three in one call; if validation fails the draft is kept and returned with the failed checks. Send an `Idempotency-Key` header to make retries safe: a repeated key with the same request returns the endpoint the first request created; reusing it with different fields returns 422 `idempotency_key_reused`. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Retry-safe create: a repeated create with the same key from the same organization returns the endpoint the first request created instead of creating another. The endpoint is returned as it is now. Reusing a key with a different request body (model, provider, base URL, upstream model ID, declared ZDR or region, or pricing) is rejected with 422 `idempotency_key_reused`. `activate` is not compared, and later edits to the endpoint do not affect the comparison.<br/>
        /// Example: wayfair-gpt-4o-eastus-2026-09
        /// </param>
        /// <param name="activate">
        /// Validate and activate in the same call. On a failed validation the draft is kept and returned with a 422, so fix it and call `/validate` and `/activate` instead of creating it again.<br/>
        /// Example: {"workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
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
        /// <param name="modelPermaslug">
        /// Permanent slug of the model this endpoint serves.<br/>
        /// Example: openai/gpt-4o-2024-08-06
        /// </param>
        /// <param name="pricing">
        /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
        /// Example: {"completion":"0.00001","prompt":"0.0000025"}
        /// </param>
        /// <param name="providerSlug">
        /// Slug of the upstream provider.<br/>
        /// Example: azure
        /// </param>
        /// <param name="upstreamModelId">
        /// Model or deployment identifier sent to the upstream provider.<br/>
        /// Example: gpt-4o-prod
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ManagedPrivateEndpointResponse> CreateAsync(
            string modelPermaslug,
            string providerSlug,
            string upstreamModelId,
            string? idempotencyKey = default,
            global::OpenRouter.PrivateEndpointActivation? activate = default,
            string? baseUrl = default,
            global::OpenRouter.CreatePrivateEndpointRequestDeclaredRegion? declaredRegion = default,
            bool? declaredZdr = default,
            global::OpenRouter.PrivateEndpointPricing? pricing = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}