#nullable enable

namespace OpenRouter
{
    public partial interface IOAuthClient
    {
        /// <summary>
        /// Exchange authorization code for API key<br/>
        /// Exchange an authorization code from the PKCE flow for a user-controlled API key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ExchangeAuthCodeForAPIKeyResponse> ExchangeAuthCodeForAPIKeyAsync(

            global::OpenRouter.ExchangeAuthCodeForAPIKeyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchange authorization code for API key<br/>
        /// Exchange an authorization code from the PKCE flow for a user-controlled API key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ExchangeAuthCodeForAPIKeyResponse>> ExchangeAuthCodeForAPIKeyAsResponseAsync(

            global::OpenRouter.ExchangeAuthCodeForAPIKeyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchange authorization code for API key<br/>
        /// Exchange an authorization code from the PKCE flow for a user-controlled API key
        /// </summary>
        /// <param name="code">
        /// The authorization code received from the OAuth redirect<br/>
        /// Example: auth_code_abc123def456
        /// </param>
        /// <param name="codeChallengeMethod">
        /// The method used to generate the code challenge<br/>
        /// Example: S256
        /// </param>
        /// <param name="codeVerifier">
        /// The code verifier if code_challenge was used in the authorization request<br/>
        /// Example: dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ExchangeAuthCodeForAPIKeyResponse> ExchangeAuthCodeForAPIKeyAsync(
            string code,
            global::OpenRouter.ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod? codeChallengeMethod = default,
            string? codeVerifier = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}