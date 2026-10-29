#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateEndpointsClient
    {
        /// <summary>
        /// Update a private endpoint<br/>
        /// Change any of the endpoint fields you own in one call; only the fields present change, and the response is the whole endpoint. `pricing` and `declared_parameters` replace their stored value, `settings` changes only the fields it names (`null` clears a limit or restores the provider default); routing picks these up for subsequent requests on drafts and active endpoints alike. `upstream_model_id`, `base_url`, `declared_zdr` and `declared_region` re-point a draft: an omitted `upstream_model_id` or `base_url` keeps the stored one, omitted data-policy declarations are kept while the upstream is unchanged and cleared when it changes, and any upstream change clears earlier validation. Naming an upstream field on an active endpoint returns 409 `already_active` and writes nothing; delete and re-create instead. Every group is checked before anything is written: 400 `parameters_invalid` when `tool_choice` is declared without `tools` tested or declared, 400 `settings_invalid` when `max_prompt_tokens` exceeds the context length, both completion APIs are off, or `excluded_parameters` names a tested parameter, 422 `pricing_invalid` for rates the provider strategy cannot represent. [Management key](/docs/guides/overview/auth/management-api-keys) required.
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
        /// Update a private endpoint<br/>
        /// Change any of the endpoint fields you own in one call; only the fields present change, and the response is the whole endpoint. `pricing` and `declared_parameters` replace their stored value, `settings` changes only the fields it names (`null` clears a limit or restores the provider default); routing picks these up for subsequent requests on drafts and active endpoints alike. `upstream_model_id`, `base_url`, `declared_zdr` and `declared_region` re-point a draft: an omitted `upstream_model_id` or `base_url` keeps the stored one, omitted data-policy declarations are kept while the upstream is unchanged and cleared when it changes, and any upstream change clears earlier validation. Naming an upstream field on an active endpoint returns 409 `already_active` and writes nothing; delete and re-create instead. Every group is checked before anything is written: 400 `parameters_invalid` when `tool_choice` is declared without `tools` tested or declared, 400 `settings_invalid` when `max_prompt_tokens` exceeds the context length, both completion APIs are off, or `excluded_parameters` names a tested parameter, 422 `pricing_invalid` for rates the provider strategy cannot represent. [Management key](/docs/guides/overview/auth/management-api-keys) required.
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
        /// Update a private endpoint<br/>
        /// Change any of the endpoint fields you own in one call; only the fields present change, and the response is the whole endpoint. `pricing` and `declared_parameters` replace their stored value, `settings` changes only the fields it names (`null` clears a limit or restores the provider default); routing picks these up for subsequent requests on drafts and active endpoints alike. `upstream_model_id`, `base_url`, `declared_zdr` and `declared_region` re-point a draft: an omitted `upstream_model_id` or `base_url` keeps the stored one, omitted data-policy declarations are kept while the upstream is unchanged and cleared when it changes, and any upstream change clears earlier validation. Naming an upstream field on an active endpoint returns 409 `already_active` and writes nothing; delete and re-create instead. Every group is checked before anything is written: 400 `parameters_invalid` when `tool_choice` is declared without `tools` tested or declared, 400 `settings_invalid` when `max_prompt_tokens` exceeds the context length, both completion APIs are off, or `excluded_parameters` names a tested parameter, 422 `pricing_invalid` for rates the provider strategy cannot represent. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="baseUrl">
        /// HTTPS base URL of your deployment. Required unless the provider derives its URL from the BYOK credential (Azure, Amazon Bedrock, Google Vertex).<br/>
        /// Example: https://contoso.openai.azure.com
        /// </param>
        /// <param name="declaredParameters">
        /// Parameters the upstream supports beyond the tested ones. Replaces the earlier declaration; tested parameters stay. Order and repeated names are ignored, but the list holds at most as many entries as there are declarable parameters, repeats included. `tool_choice` requires `tools` to be tested or declared.<br/>
        /// Example: [temperature, seed]
        /// </param>
        /// <param name="declaredRegion">
        /// Attest where this deployment processes data.<br/>
        /// Example: us
        /// </param>
        /// <param name="declaredZdr">
        /// Attest that this deployment retains no prompt or completion data.
        /// </param>
        /// <param name="pricing"></param>
        /// <param name="settings"></param>
        /// <param name="upstreamModelId">
        /// Model or deployment identifier sent to the upstream provider.<br/>
        /// Example: gpt-4o-prod
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.PrivateEndpointResponse> UpdateAsync(
            global::System.Guid id,
            string? baseUrl = default,
            global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointDeclaredParameter>? declaredParameters = default,
            global::OpenRouter.UpdatePrivateEndpointRequestDeclaredRegion? declaredRegion = default,
            bool? declaredZdr = default,
            global::OpenRouter.AllOf<global::OpenRouter.PrivateEndpointPricing, object>? pricing = default,
            global::OpenRouter.AllOf<global::OpenRouter.UpdatePrivateEndpointSettingsRequest, object>? settings = default,
            string? upstreamModelId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}