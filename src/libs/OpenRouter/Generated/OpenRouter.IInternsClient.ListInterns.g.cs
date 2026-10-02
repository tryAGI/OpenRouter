#nullable enable

namespace OpenRouter
{
    public partial interface IInternsClient
    {
        /// <summary>
        /// List interns<br/>
        /// Lists interns visible to the authenticated key, newest first. Filter by workspace and one or more lifecycle statuses. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of interns to return, from 1 through 500.<br/>
        /// Example: 50
        /// </param>
        /// <param name="status">
        /// Comma-separated lifecycle statuses to include, at most 8. Repeats are collapsed.<br/>
        /// Example: [queued, running]
        /// </param>
        /// <param name="startingAfter">
        /// The opaque `next_cursor` of the previous page. Returns the interns that come after it in the newest-first order. A malformed cursor is a 400.<br/>
        /// Example: MjAyNi0wOS0xNlQwODozMDowMC4wMDAwMDBafDdjOWU2Njc5LTc0MjUtNDBkZS05NDRiLWUwN2ZjMWY5MGFlNw
        /// </param>
        /// <param name="workspaceId">
        /// Only return interns in this workspace. It must match the API key workspace.<br/>
        /// Example: 89f9f5b2-3f89-4eaf-83ca-5ceae149e8bb
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.InternListResponse> ListInternsAsync(
            int? limit = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ListInternsStatu>? status = default,
            string? startingAfter = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List interns<br/>
        /// Lists interns visible to the authenticated key, newest first. Filter by workspace and one or more lifecycle statuses. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of interns to return, from 1 through 500.<br/>
        /// Example: 50
        /// </param>
        /// <param name="status">
        /// Comma-separated lifecycle statuses to include, at most 8. Repeats are collapsed.<br/>
        /// Example: [queued, running]
        /// </param>
        /// <param name="startingAfter">
        /// The opaque `next_cursor` of the previous page. Returns the interns that come after it in the newest-first order. A malformed cursor is a 400.<br/>
        /// Example: MjAyNi0wOS0xNlQwODozMDowMC4wMDAwMDBafDdjOWU2Njc5LTc0MjUtNDBkZS05NDRiLWUwN2ZjMWY5MGFlNw
        /// </param>
        /// <param name="workspaceId">
        /// Only return interns in this workspace. It must match the API key workspace.<br/>
        /// Example: 89f9f5b2-3f89-4eaf-83ca-5ceae149e8bb
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.InternListResponse>> ListInternsAsResponseAsync(
            int? limit = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ListInternsStatu>? status = default,
            string? startingAfter = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}