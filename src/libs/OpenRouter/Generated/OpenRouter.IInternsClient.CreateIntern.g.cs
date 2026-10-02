#nullable enable

namespace OpenRouter
{
    public partial interface IInternsClient
    {
        /// <summary>
        /// Create an intern<br/>
        /// Creates an intern in an explicit workspace. The operation also creates its private vault. It can start provisioning immediately or wait for a later provision call. A retry with the same idempotency key and body resumes unfinished work. The request body is capped at 1048576 bytes and a larger body is refused with 413. A non-empty body must declare `Content-Type: application/json` or it is refused with 415. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Key that makes retries resume the same create operation, from 1 through 255 characters. An empty or longer key is refused with 400. Without the header, the server derives a stable key from the request body.<br/>
        /// Example: create-research-assistant-2026-09-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.Intern> CreateInternAsync(

            global::OpenRouter.CreateInternRequest request,
            string? idempotencyKey = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an intern<br/>
        /// Creates an intern in an explicit workspace. The operation also creates its private vault. It can start provisioning immediately or wait for a later provision call. A retry with the same idempotency key and body resumes unfinished work. The request body is capped at 1048576 bytes and a larger body is refused with 413. A non-empty body must declare `Content-Type: application/json` or it is refused with 415. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Key that makes retries resume the same create operation, from 1 through 255 characters. An empty or longer key is refused with 400. Without the header, the server derives a stable key from the request body.<br/>
        /// Example: create-research-assistant-2026-09-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.Intern>> CreateInternAsResponseAsync(

            global::OpenRouter.CreateInternRequest request,
            string? idempotencyKey = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an intern<br/>
        /// Creates an intern in an explicit workspace. The operation also creates its private vault. It can start provisioning immediately or wait for a later provision call. A retry with the same idempotency key and body resumes unfinished work. The request body is capped at 1048576 bytes and a larger body is refused with 413. A non-empty body must declare `Content-Type: application/json` or it is refused with 415. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Key that makes retries resume the same create operation, from 1 through 255 characters. An empty or longer key is refused with 400. Without the header, the server derives a stable key from the request body.<br/>
        /// Example: create-research-assistant-2026-09-16
        /// </param>
        /// <param name="description">
        /// Free-form description, or null.
        /// </param>
        /// <param name="instructions">
        /// Standing instructions the intern boots with, or null.
        /// </param>
        /// <param name="name">
        /// Intern name, unique per creator within the workspace.
        /// </param>
        /// <param name="provision">
        /// Start provisioning during this create operation. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="vaultId">
        /// Vault owned by another intern in this workspace to attach as a borrowed vault.
        /// </param>
        /// <param name="workspaceId">
        /// Workspace that will own the intern. Defaults to the workspace the API key resolves to. When given, it must match the API key workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.Intern> CreateInternAsync(
            string name,
            string? idempotencyKey = default,
            string? description = default,
            string? instructions = default,
            bool? provision = default,
            global::System.Guid? vaultId = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}