#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageApiKeysClient
    {
        /// <summary>
        /// Create a new API key<br/>
        /// Create a new API key for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ApiKeysCreateKeysResponse201> CreateKeysAsync(

            global::OpenRouter.CreateKeysRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new API key<br/>
        /// Create a new API key for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="creatorUserId">
        /// Optional user ID of the key creator. Only meaningful for organization-owned keys where a specific member is creating the key.
        /// </param>
        /// <param name="expiresAt">
        /// Optional ISO 8601 UTC timestamp when the API key should expire. Must be UTC, other timezones will be rejected
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit
        /// </param>
        /// <param name="limit">
        /// Optional spending limit for the API key in USD
        /// </param>
        /// <param name="limitReset">
        /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </param>
        /// <param name="name">
        /// Name for the new API key
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ApiKeysCreateKeysResponse201> CreateKeysAsync(
            string name,
            string? creatorUserId = default,
            global::System.DateTime? expiresAt = default,
            bool? includeByokInLimit = default,
            double? limit = default,
            global::OpenRouter.OneOf<global::OpenRouter.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>? limitReset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}