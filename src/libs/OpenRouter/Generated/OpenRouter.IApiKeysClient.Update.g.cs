#nullable enable

namespace OpenRouter
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Update an API key<br/>
        /// Update an existing API key. Authenticate with a [management key](/docs/guides/overview/auth/management-api-keys).<br/>
        /// &lt;Warning&gt;<br/>
        /// You can't change `workspace_id` through the API. The request body accepts only the fields listed below, and unrecognized fields are ignored. To move a key to another workspace, use the OpenRouter dashboard. If the body contains none of the accepted fields, the request fails with `400` and the message `No update fields provided`.<br/>
        /// &lt;/Warning&gt;
        /// </summary>
        /// <param name="hash">
        /// The hash identifier of the API key to update<br/>
        /// Example: f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateKeysResponse> UpdateAsync(
            string hash,

            global::OpenRouter.UpdateKeysRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an API key<br/>
        /// Update an existing API key. Authenticate with a [management key](/docs/guides/overview/auth/management-api-keys).<br/>
        /// &lt;Warning&gt;<br/>
        /// You can't change `workspace_id` through the API. The request body accepts only the fields listed below, and unrecognized fields are ignored. To move a key to another workspace, use the OpenRouter dashboard. If the body contains none of the accepted fields, the request fails with `400` and the message `No update fields provided`.<br/>
        /// &lt;/Warning&gt;
        /// </summary>
        /// <param name="hash">
        /// The hash identifier of the API key to update<br/>
        /// Example: f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpdateKeysResponse>> UpdateAsResponseAsync(
            string hash,

            global::OpenRouter.UpdateKeysRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an API key<br/>
        /// Update an existing API key. Authenticate with a [management key](/docs/guides/overview/auth/management-api-keys).<br/>
        /// &lt;Warning&gt;<br/>
        /// You can't change `workspace_id` through the API. The request body accepts only the fields listed below, and unrecognized fields are ignored. To move a key to another workspace, use the OpenRouter dashboard. If the body contains none of the accepted fields, the request fails with `400` and the message `No update fields provided`.<br/>
        /// &lt;/Warning&gt;
        /// </summary>
        /// <param name="hash">
        /// The hash identifier of the API key to update<br/>
        /// Example: f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943
        /// </param>
        /// <param name="disabled">
        /// Whether to disable the API key<br/>
        /// Example: false
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit<br/>
        /// Example: true
        /// </param>
        /// <param name="limit">
        /// New spending limit for the API key in USD<br/>
        /// Example: 75
        /// </param>
        /// <param name="limitReset">
        /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.<br/>
        /// Example: daily
        /// </param>
        /// <param name="name">
        /// New name for the API key<br/>
        /// Example: Updated API Key Name
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateKeysResponse> UpdateAsync(
            string hash,
            bool? disabled = default,
            bool? includeByokInLimit = default,
            double? limit = default,
            global::OpenRouter.UpdateKeysRequestLimitReset? limitReset = default,
            string? name = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}