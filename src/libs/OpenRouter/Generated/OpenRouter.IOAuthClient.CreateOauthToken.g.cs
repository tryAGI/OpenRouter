#nullable enable

namespace OpenRouter
{
    public partial interface IOAuthClient
    {
        /// <summary>
        /// Exchange a workload identity token<br/>
        /// RFC 8693 token exchange. Presents a JWT from an issuer your organization trusts (Settings → Workload identity) and receives a short-lived OpenRouter access token that acts as the API key the matching federation policy targets.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.TokenExchangeResponse> CreateOauthTokenAsync(

            global::OpenRouter.TokenExchangeRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchange a workload identity token<br/>
        /// RFC 8693 token exchange. Presents a JWT from an issuer your organization trusts (Settings → Workload identity) and receives a short-lived OpenRouter access token that acts as the API key the matching federation policy targets.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.TokenExchangeResponse>> CreateOauthTokenAsResponseAsync(

            global::OpenRouter.TokenExchangeRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchange a workload identity token<br/>
        /// RFC 8693 token exchange. Presents a JWT from an issuer your organization trusts (Settings → Workload identity) and receives a short-lived OpenRouter access token that acts as the API key the matching federation policy targets.
        /// </summary>
        /// <param name="federationPolicyId">
        /// The federation policy to evaluate, from Settings → Workload identity. Binds the exchange to one organization.<br/>
        /// Example: 4b2f7d1e-8c3a-4e5f-9a6b-1c2d3e4f5a6b
        /// </param>
        /// <param name="grantType">
        /// Must be `urn:ietf:params:oauth:grant-type:token-exchange`.<br/>
        /// Example: urn:ietf:params:oauth:grant-type:token-exchange
        /// </param>
        /// <param name="requestedTokenType">
        /// Optional; when present must be `urn:ietf:params:oauth:token-type:access_token`.<br/>
        /// Example: urn:ietf:params:oauth:token-type:access_token
        /// </param>
        /// <param name="scope">
        /// Optional; only `inference` is available.<br/>
        /// Example: inference
        /// </param>
        /// <param name="subjectToken">
        /// The JWT issued by your identity provider.<br/>
        /// Example: &lt;jwt from your identity provider&gt;
        /// </param>
        /// <param name="subjectTokenType">
        /// Must be `urn:ietf:params:oauth:token-type:jwt`.<br/>
        /// Example: urn:ietf:params:oauth:token-type:jwt
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.TokenExchangeResponse> CreateOauthTokenAsync(
            global::System.Guid federationPolicyId,
            string subjectToken,
            global::OpenRouter.TokenExchangeRequestGrantType grantType = default,
            global::OpenRouter.TokenExchangeRequestRequestedTokenType? requestedTokenType = default,
            global::OpenRouter.TokenExchangeRequestScope? scope = default,
            global::OpenRouter.TokenExchangeRequestSubjectTokenType subjectTokenType = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}