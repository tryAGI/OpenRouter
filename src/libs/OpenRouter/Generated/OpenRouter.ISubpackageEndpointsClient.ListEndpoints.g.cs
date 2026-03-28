#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageEndpointsClient
    {
        /// <summary>
        /// List all endpoints for a model
        /// </summary>
        /// <param name="author"></param>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.EndpointsListEndpointsResponse200> ListEndpointsAsync(
            string author,
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}