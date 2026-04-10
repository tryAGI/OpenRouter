#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageOAuthClient
    {
        /// <summary>
        /// Exchange authorization code for API key<br/>
        /// Exchange an authorization code from the PKCE flow for a user-controlled API key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.OAuthExchangeAuthCodeForAPIKeyResponse200> ExchangeAuthCodeForApiKeyAsync(

            global::OpenRouter.ExchangeAuthCodeForApiKeyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchange authorization code for API key<br/>
        /// Exchange an authorization code from the PKCE flow for a user-controlled API key
        /// </summary>
        /// <param name="code">
        /// The authorization code received from the OAuth redirect
        /// </param>
        /// <param name="codeChallengeMethod">
        /// The method used to generate the code challenge
        /// </param>
        /// <param name="codeVerifier">
        /// The code verifier if code_challenge was used in the authorization request
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.OAuthExchangeAuthCodeForAPIKeyResponse200> ExchangeAuthCodeForApiKeyAsync(
            string code,
            global::OpenRouter.OneOf<global::OpenRouter.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod?, object>? codeChallengeMethod = default,
            string? codeVerifier = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}