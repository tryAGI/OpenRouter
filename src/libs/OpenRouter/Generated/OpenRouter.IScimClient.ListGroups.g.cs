#nullable enable

namespace OpenRouter
{
    public partial interface IScimClient
    {
        /// <summary>
        /// List SCIM groups<br/>
        /// List SCIM groups for the organization. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 100)<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="displayName">
        /// Exact match filter on display_name. Omitted or empty returns groups unfiltered by name (subject to offset/limit). When external_id is also present, both must match.<br/>
        /// Example: Engineering
        /// </param>
        /// <param name="externalId">
        /// Exact match filter on external_id, e.g. the identity provider (such as Entra ID) group object ID. Omitted or empty returns groups unfiltered by external_id (subject to offset/limit). When display_name is also present, both must match.<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListScimGroupsResponse> ListGroupsAsync(
            int? offset = default,
            int? limit = default,
            string? displayName = default,
            string? externalId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List SCIM groups<br/>
        /// List SCIM groups for the organization. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 100)<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="displayName">
        /// Exact match filter on display_name. Omitted or empty returns groups unfiltered by name (subject to offset/limit). When external_id is also present, both must match.<br/>
        /// Example: Engineering
        /// </param>
        /// <param name="externalId">
        /// Exact match filter on external_id, e.g. the identity provider (such as Entra ID) group object ID. Omitted or empty returns groups unfiltered by external_id (subject to offset/limit). When display_name is also present, both must match.<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListScimGroupsResponse>> ListGroupsAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? displayName = default,
            string? externalId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}