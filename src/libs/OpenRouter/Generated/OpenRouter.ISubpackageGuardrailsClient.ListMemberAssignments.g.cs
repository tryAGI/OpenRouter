#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// List all member assignments<br/>
        /// List all organization member guardrail assignments for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GuardrailsListMemberAssignmentsResponse200> ListMemberAssignmentsAsync(
            string? offset = default,
            string? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}