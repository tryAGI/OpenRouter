#nullable enable

namespace OpenRouter
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete a workspace<br/>
        /// Delete an existing workspace. Workspaces with active API keys cannot be deleted; remove the keys first. Deleting the default workspace requires confirm_default_workspace_deletion=true. Deleting any workspace permanently deletes its budgets and guardrails and disables its classifiers and broadcast destinations. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="confirmDefaultWorkspaceDeletion">
        /// Required to delete the default workspace. Deleting it permanently disables the account’s unscoped inference API keys (management/provisioning keys are retained) and its budgets, guardrails, classifiers, and broadcast destinations. Ignored for non-default workspaces.<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DeleteWorkspaceResponse> DeleteAsync(
            string id,
            bool? confirmDefaultWorkspaceDeletion = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a workspace<br/>
        /// Delete an existing workspace. Workspaces with active API keys cannot be deleted; remove the keys first. Deleting the default workspace requires confirm_default_workspace_deletion=true. Deleting any workspace permanently deletes its budgets and guardrails and disables its classifiers and broadcast destinations. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="confirmDefaultWorkspaceDeletion">
        /// Required to delete the default workspace. Deleting it permanently disables the account’s unscoped inference API keys (management/provisioning keys are retained) and its budgets, guardrails, classifiers, and broadcast destinations. Ignored for non-default workspaces.<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.DeleteWorkspaceResponse>> DeleteAsResponseAsync(
            string id,
            bool? confirmDefaultWorkspaceDeletion = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}