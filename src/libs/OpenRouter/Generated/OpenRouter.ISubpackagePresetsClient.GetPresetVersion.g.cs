#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackagePresetsClient
    {
        /// <summary>
        /// Get a specific version of a preset<br/>
        /// Retrieves a specific version of a preset by its slug and version number.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GetPresetVersionResponse> GetPresetVersionAsync(
            string slug,
            string version,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a specific version of a preset<br/>
        /// Retrieves a specific version of a preset by its slug and version number.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GetPresetVersionResponse>> GetPresetVersionAsResponseAsync(
            string slug,
            string version,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}