#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// Bulk unassign members from a guardrail<br/>
        /// Unassign multiple organization members from a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GuardrailsBulkUnassignMembersFromGuardrailResponse200> BulkUnassignMembersFromGuardrailAsync(
            global::System.Guid id,

            global::OpenRouter.BulkUnassignMembersFromGuardrailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk unassign members from a guardrail<br/>
        /// Unassign multiple organization members from a specific guardrail. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="memberUserIds">
        /// Array of member user IDs to unassign from the guardrail
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GuardrailsBulkUnassignMembersFromGuardrailResponse200> BulkUnassignMembersFromGuardrailAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string> memberUserIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}