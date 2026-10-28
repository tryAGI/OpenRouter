#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateEndpointsClient
    {
        /// <summary>
        /// Set private endpoint supported parameters<br/>
        /// Declare which request parameters the upstream supports beyond the ones validation proved. Applies to drafts and active endpoints; routing picks the change up for subsequent requests. The body replaces the earlier declaration and is read as a set: order and repeated names do not matter, but the list holds at most as many entries as there are declarable parameters, repeats included. `tested_parameters` stay. Returns 400 `parameters_invalid` when `tool_choice` is declared without `tools` being tested or declared. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.PrivateEndpointResponse> UpdateParametersAsync(
            global::System.Guid id,

            global::OpenRouter.UpdatePrivateEndpointParametersRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set private endpoint supported parameters<br/>
        /// Declare which request parameters the upstream supports beyond the ones validation proved. Applies to drafts and active endpoints; routing picks the change up for subsequent requests. The body replaces the earlier declaration and is read as a set: order and repeated names do not matter, but the list holds at most as many entries as there are declarable parameters, repeats included. `tested_parameters` stay. Returns 400 `parameters_invalid` when `tool_choice` is declared without `tools` being tested or declared. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.PrivateEndpointResponse>> UpdateParametersAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.UpdatePrivateEndpointParametersRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set private endpoint supported parameters<br/>
        /// Declare which request parameters the upstream supports beyond the ones validation proved. Applies to drafts and active endpoints; routing picks the change up for subsequent requests. The body replaces the earlier declaration and is read as a set: order and repeated names do not matter, but the list holds at most as many entries as there are declarable parameters, repeats included. `tested_parameters` stay. Returns 400 `parameters_invalid` when `tool_choice` is declared without `tools` being tested or declared. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="declaredParameters">
        /// Parameters the upstream supports beyond the tested ones. Replaces the earlier declaration; tested parameters stay. Order and repeated names are ignored, but the list holds at most as many entries as there are declarable parameters, repeats included. `tool_choice` requires `tools` to be tested or declared.<br/>
        /// Example: [temperature, seed]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.PrivateEndpointResponse> UpdateParametersAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointDeclaredParameter> declaredParameters,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}