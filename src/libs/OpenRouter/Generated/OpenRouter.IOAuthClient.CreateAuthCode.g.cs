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
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateAuthKeysCodeResponse> CreateAuthCodeAsync(

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
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreateAuthKeysCodeResponse>> CreateAuthCodeAsResponseAsync(

            global::OpenRouter.CreateAuthKeysCodeRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create authorization code<br/>
        /// Create an authorization code for the PKCE flow to generate a user-controlled API key
        /// </summary>
        /// <param name="callbackUrl">
        /// The callback URL to redirect to after authorization. Supports https URLs and localhost/127.0.0.1 URLs on any port for local CLI tools.<br/>
        /// Example: https://myapp.com/auth/callback
        /// </param>
        /// <param name="codeChallenge">
        /// PKCE code challenge for enhanced security<br/>
        /// Example: E9Melhoa2OwvFrEMTJguCHaoeK1t8URWbuGJSstw-cM
        /// </param>
        /// <param name="codeChallengeMethod">
        /// The method used to generate the code challenge<br/>
        /// Example: S256
        /// </param>
        /// <param name="expiresAt">
        /// Optional ISO 8601 UTC expiration timestamp. Must include seconds (YYYY-MM-DDTHH:MM:SSZ; fractional seconds allowed); minute-precision timestamps are rejected.<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </param>
        /// <param name="keyLabel">
        /// Optional custom label for the API key. Defaults to the app name if not provided.<br/>
        /// Example: My Custom Key
        /// </param>
        /// <param name="limit">
        /// Credit limit for the API key to be created<br/>
        /// Example: 100
        /// </param>
        /// <param name="spawnAgent">
        /// Agent identifier for spawn telemetry<br/>
        /// Example: my-agent
        /// </param>
        /// <param name="spawnCloud">
        /// Cloud identifier for spawn telemetry<br/>
        /// Example: aws-us-east-1
        /// </param>
        /// <param name="usageLimitType">
        /// Optional credit limit reset interval. When set, the credit limit resets on this interval.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID to associate the API key with
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateAuthKeysCodeResponse> CreateAuthCodeAsync(
            string callbackUrl,
            string? codeChallenge = default,
            global::OpenRouter.CreateAuthKeysCodeRequestCodeChallengeMethod? codeChallengeMethod = default,
            global::System.DateTime? expiresAt = default,
            string? keyLabel = default,
            double? limit = default,
            string? spawnAgent = default,
            string? spawnCloud = default,
            global::OpenRouter.CreateAuthKeysCodeRequestUsageLimitType? usageLimitType = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}