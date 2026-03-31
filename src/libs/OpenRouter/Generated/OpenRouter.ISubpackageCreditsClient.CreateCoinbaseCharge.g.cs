#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageCreditsClient
    {
        /// <summary>
        /// Deprecated Coinbase Commerce charge endpoint<br/>
        /// Deprecated. The Coinbase APIs used by this endpoint have been deprecated, so Coinbase Commerce charges have been removed. Use the web credits purchase flow instead.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateCoinbaseChargeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}