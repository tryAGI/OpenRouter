#nullable enable

namespace OpenRouter
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Get user activity grouped by endpoint<br/>
        /// Returns user activity data grouped by endpoint for the last 30 (completed) UTC days. Pass `workspace_id` to scope the response to a single workspace. Pass `group_by=workspace` to split each row per workspace and include `workspace_id` on every item; by default rows are aggregated across workspaces and `workspace_id` is not returned. Activity recorded before workspace resolution existed is permanently attributed to the account default workspace (no backfill is possible). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="date">
        /// Filter by a single UTC date in the last 30 days (YYYY-MM-DD format).<br/>
        /// Example: 2025-08-24
        /// </param>
        /// <param name="apiKeyHash">
        /// Filter by API key hash (SHA-256 hex string, as returned by the keys API).<br/>
        /// Example: abc123def456...
        /// </param>
        /// <param name="userId">
        /// Filter by org member user ID. Only applicable for organization accounts.<br/>
        /// Example: user_abc123
        /// </param>
        /// <param name="groupBy">
        /// Set to 'workspace' to split each row per workspace and include `workspace_id` on every item. Omitted by default, in which case rows are aggregated across workspaces (by date, model, and endpoint) and `workspace_id` is not returned — preserving the historical response shape.<br/>
        /// Example: workspace
        /// </param>
        /// <param name="workspaceId">
        /// Filter by workspace ID (UUID). Returns only activity attributed to that workspace. The workspace must belong to the authenticated account.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ActivityResponse> GetUserActivityAsync(
            string? date = default,
            string? apiKeyHash = default,
            string? userId = default,
            global::OpenRouter.GetUserActivityGroupBy? groupBy = default,
            string? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user activity grouped by endpoint<br/>
        /// Returns user activity data grouped by endpoint for the last 30 (completed) UTC days. Pass `workspace_id` to scope the response to a single workspace. Pass `group_by=workspace` to split each row per workspace and include `workspace_id` on every item; by default rows are aggregated across workspaces and `workspace_id` is not returned. Activity recorded before workspace resolution existed is permanently attributed to the account default workspace (no backfill is possible). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="date">
        /// Filter by a single UTC date in the last 30 days (YYYY-MM-DD format).<br/>
        /// Example: 2025-08-24
        /// </param>
        /// <param name="apiKeyHash">
        /// Filter by API key hash (SHA-256 hex string, as returned by the keys API).<br/>
        /// Example: abc123def456...
        /// </param>
        /// <param name="userId">
        /// Filter by org member user ID. Only applicable for organization accounts.<br/>
        /// Example: user_abc123
        /// </param>
        /// <param name="groupBy">
        /// Set to 'workspace' to split each row per workspace and include `workspace_id` on every item. Omitted by default, in which case rows are aggregated across workspaces (by date, model, and endpoint) and `workspace_id` is not returned — preserving the historical response shape.<br/>
        /// Example: workspace
        /// </param>
        /// <param name="workspaceId">
        /// Filter by workspace ID (UUID). Returns only activity attributed to that workspace. The workspace must belong to the authenticated account.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ActivityResponse>> GetUserActivityAsResponseAsync(
            string? date = default,
            string? apiKeyHash = default,
            string? userId = default,
            global::OpenRouter.GetUserActivityGroupBy? groupBy = default,
            string? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}