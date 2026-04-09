#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageApiKeysClient
    {
        /// <summary>
        /// Update an API key<br/>
        /// Update an existing API key. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ApiKeysUpdateKeysResponse200> UpdateKeysAsync(
            string hash,

            global::OpenRouter.UpdateKeysRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an API key<br/>
        /// Update an existing API key. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="disabled">
        /// Whether to disable the API key
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit
        /// </param>
        /// <param name="limit">
        /// New spending limit for the API key in USD
        /// </param>
        /// <param name="limitReset">
        /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </param>
        /// <param name="name">
        /// New name for the API key
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ApiKeysUpdateKeysResponse200> UpdateKeysAsync(
            string hash,
            bool? disabled = default,
            bool? includeByokInLimit = default,
            double? limit = default,
            global::OpenRouter.OneOf<global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?, object>? limitReset = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}