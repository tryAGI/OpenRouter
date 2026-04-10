#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageEndpointsClient
    {
        /// <summary>
        /// Preview the impact of ZDR on the available endpoints
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.EndpointsListEndpointsZdrResponse200> ListEndpointsZdrAsync(
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}