#nullable enable

namespace OpenRouter
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create a new API key<br/>
        /// Create a new API key for the authenticated user. The plaintext `key` is returned only in this response. Treat it as a write-only, sensitive value; it cannot be retrieved later. Authenticate with a [management key](/docs/guides/overview/auth/management-api-keys). The optional `external` object associates the key with a partner-defined user and lookup key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateKeysResponse> CreateAsync(

            global::OpenRouter.CreateKeysRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new API key<br/>
        /// Create a new API key for the authenticated user. The plaintext `key` is returned only in this response. Treat it as a write-only, sensitive value; it cannot be retrieved later. Authenticate with a [management key](/docs/guides/overview/auth/management-api-keys). The optional `external` object associates the key with a partner-defined user and lookup key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreateKeysResponse>> CreateAsResponseAsync(

            global::OpenRouter.CreateKeysRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new API key<br/>
        /// Create a new API key for the authenticated user. The plaintext `key` is returned only in this response. Treat it as a write-only, sensitive value; it cannot be retrieved later. Authenticate with a [management key](/docs/guides/overview/auth/management-api-keys). The optional `external` object associates the key with a partner-defined user and lookup key.
        /// </summary>
        /// <param name="creatorUserId">
        /// Optional user ID of the key creator. Only meaningful for organization-owned keys where a specific member is creating the key.<br/>
        /// Example: user_2dHFtVWx2n56w6HkM0000000000
        /// </param>
        /// <param name="expiresAt">
        /// Optional ISO 8601 UTC expiration timestamp. Must include seconds (YYYY-MM-DDTHH:MM:SSZ; fractional seconds allowed); minute-precision timestamps are rejected.<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </param>
        /// <param name="external">
        /// Optional partner-defined identity associated with the created API key.
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit<br/>
        /// Example: true
        /// </param>
        /// <param name="limit">
        /// Optional spending limit for the API key in USD<br/>
        /// Example: 50
        /// </param>
        /// <param name="limitReset">
        /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="name">
        /// Name for the new API key<br/>
        /// Example: My New API Key
        /// </param>
        /// <param name="workspaceId">
        /// The workspace to create the API key in. Defaults to the default workspace if not provided.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateKeysResponse> CreateAsync(
            string name,
            string? creatorUserId = default,
            global::System.DateTime? expiresAt = default,
            global::OpenRouter.CreateKeysRequestExternal? external = default,
            bool? includeByokInLimit = default,
            double? limit = default,
            global::OpenRouter.CreateKeysRequestLimitReset? limitReset = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}