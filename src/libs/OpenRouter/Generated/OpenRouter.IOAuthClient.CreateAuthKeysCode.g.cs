#nullable enable

namespace OpenRouter
{
    public partial interface IOAuthClient
    {
        /// <summary>
        /// Create authorization code<br/>
        /// Create an authorization code for the PKCE flow to generate a user-controlled API key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.OAuthCreateAuthKeysCodeResponse200> CreateAuthKeysCodeAsync(

            global::OpenRouter.CreateAuthKeysCodeRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create authorization code<br/>
        /// Create an authorization code for the PKCE flow to generate a user-controlled API key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.OAuthCreateAuthKeysCodeResponse200>> CreateAuthKeysCodeAsResponseAsync(

            global::OpenRouter.CreateAuthKeysCodeRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create authorization code<br/>
        /// Create an authorization code for the PKCE flow to generate a user-controlled API key
        /// </summary>
        /// <param name="callbackUrl">
        /// The callback URL to redirect to after authorization. Supports https URLs and localhost/127.0.0.1 URLs on any port for local CLI tools.
        /// </param>
        /// <param name="codeChallenge">
        /// PKCE code challenge for enhanced security
        /// </param>
        /// <param name="codeChallengeMethod">
        /// The method used to generate the code challenge
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration time for the API key to be created
        /// </param>
        /// <param name="keyLabel">
        /// Optional custom label for the API key. Defaults to the app name if not provided.
        /// </param>
        /// <param name="limit">
        /// Credit limit for the API key to be created
        /// </param>
        /// <param name="usageLimitType">
        /// Optional credit limit reset interval. When set, the credit limit resets on this interval.
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID to associate the API key with
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.OAuthCreateAuthKeysCodeResponse200> CreateAuthKeysCodeAsync(
            string callbackUrl,
            string? codeChallenge = default,
            global::OpenRouter.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod? codeChallengeMethod = default,
            global::System.DateTime? expiresAt = default,
            string? keyLabel = default,
            double? limit = default,
            global::OpenRouter.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType? usageLimitType = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}