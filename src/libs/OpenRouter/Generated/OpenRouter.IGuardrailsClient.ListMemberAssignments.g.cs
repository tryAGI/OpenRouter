#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// List all member assignments<br/>
        /// List all organization member guardrail assignments for the authenticated user. A workspace-scoped management key lists only its own workspace, which `workspace_id` defaults to; naming another workspace returns 403. [Management key](/docs/guides/overview/auth/management-api-keys) required.
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
        /// <param name="workspaceId">
        /// Only list assignments of guardrails in this workspace. When omitted, an organization management key lists every workspace and a workspace-scoped key lists its own workspace. A workspace-scoped key gets 403 for any other workspace.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListMemberAssignmentsResponse> ListMemberAssignmentsAsync(
            int? offset = default,
            int? limit = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all member assignments<br/>
        /// List all organization member guardrail assignments for the authenticated user. A workspace-scoped management key lists only its own workspace, which `workspace_id` defaults to; naming another workspace returns 403. [Management key](/docs/guides/overview/auth/management-api-keys) required.
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
        /// <param name="workspaceId">
        /// Only list assignments of guardrails in this workspace. When omitted, an organization management key lists every workspace and a workspace-scoped key lists its own workspace. A workspace-scoped key gets 403 for any other workspace.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListMemberAssignmentsResponse>> ListMemberAssignmentsAsResponseAsync(
            int? offset = default,
            int? limit = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}