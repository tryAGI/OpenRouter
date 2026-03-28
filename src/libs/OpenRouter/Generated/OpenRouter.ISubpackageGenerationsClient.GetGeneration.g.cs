#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageGenerationsClient
    {
        /// <summary>
        /// Get request &amp; usage metadata for a generation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GenerationsGetGenerationResponse200> GetGenerationAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}