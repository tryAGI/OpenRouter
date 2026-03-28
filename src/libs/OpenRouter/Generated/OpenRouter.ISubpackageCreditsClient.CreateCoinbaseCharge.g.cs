#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageCreditsClient
    {
        /// <summary>
        /// Create a Coinbase charge for crypto payment<br/>
        /// Create a Coinbase charge for crypto payment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreditsCreateCoinbaseChargeResponse200> CreateCoinbaseChargeAsync(

            global::OpenRouter.CreateChargeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Coinbase charge for crypto payment<br/>
        /// Create a Coinbase charge for crypto payment
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="sender"></param>
        /// <param name="chainId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreditsCreateCoinbaseChargeResponse200> CreateCoinbaseChargeAsync(
            double amount,
            string sender,
            global::OpenRouter.CreateChargeRequestChainId chainId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}