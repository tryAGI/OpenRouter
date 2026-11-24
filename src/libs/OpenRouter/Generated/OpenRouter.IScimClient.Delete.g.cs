#nullable enable

namespace OpenRouter
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Delete a SCIM group mapping<br/>
        /// Delete a SCIM group-to-workspace mapping. For an `admin` mapping, `keep_members=true` returns `403` and leaves the mapping in place — preserving members as workspace admins is dashboard-only. Deleting a mapping that has guardrail policies attached returns `403`; remove those policies in the dashboard first. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keepMembers">
        /// Required. Whether to keep workspace members after deleting the mapping. `false` **removes** the members this mapping granted access to; `true` deletes the mapping while leaving membership intact as manually-managed. Exception: for an `admin` mapping, `keep_members=true` returns `403` and leaves the mapping in place — management keys cannot preserve members as workspace admins, so do not plan an admin mapping rotation around preserving members through this endpoint (use the dashboard instead). There is deliberately no default — omitting it returns `400` so the destructive path cannot be reached by accident. Mirrors the dashboard, whose `DeleteMappingSchema.keepMembers` is likewise required.<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DeleteScimGroupMappingResponse> DeleteAsync(
            global::System.Guid id,
            global::OpenRouter.AnyOf<global::OpenRouter.DeleteScimGroupMappingKeepMembers2?, bool?> keepMembers,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a SCIM group mapping<br/>
        /// Delete a SCIM group-to-workspace mapping. For an `admin` mapping, `keep_members=true` returns `403` and leaves the mapping in place — preserving members as workspace admins is dashboard-only. Deleting a mapping that has guardrail policies attached returns `403`; remove those policies in the dashboard first. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="keepMembers">
        /// Required. Whether to keep workspace members after deleting the mapping. `false` **removes** the members this mapping granted access to; `true` deletes the mapping while leaving membership intact as manually-managed. Exception: for an `admin` mapping, `keep_members=true` returns `403` and leaves the mapping in place — management keys cannot preserve members as workspace admins, so do not plan an admin mapping rotation around preserving members through this endpoint (use the dashboard instead). There is deliberately no default — omitting it returns `400` so the destructive path cannot be reached by accident. Mirrors the dashboard, whose `DeleteMappingSchema.keepMembers` is likewise required.<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.DeleteScimGroupMappingResponse>> DeleteAsResponseAsync(
            global::System.Guid id,
            global::OpenRouter.AnyOf<global::OpenRouter.DeleteScimGroupMappingKeepMembers2?, bool?> keepMembers,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}