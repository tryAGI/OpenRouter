#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageEndpointsClient
    {
        /// <summary>
        /// Preview the impact of ZDR on the available endpoints
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.EndpointsListEndpointsZdrResponse200> ListEndpointsZdrAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}