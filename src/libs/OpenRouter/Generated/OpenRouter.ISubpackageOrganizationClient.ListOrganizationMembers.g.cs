#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageOrganizationClient
    {
        /// <summary>
        /// List organization members<br/>
        /// List all members of the organization associated with the authenticated management key. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.OrganizationListOrganizationMembersResponse200> ListOrganizationMembersAsync(
            int? offset = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}