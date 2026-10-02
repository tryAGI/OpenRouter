#nullable enable

namespace OpenRouter
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Cost per session by harness and model<br/>
        /// Returns weekly refreshed, aggregated cost-per-session cells for the published harnesses.<br/>
        /// Sessions are never pooled across apps. Medians are of per-session USD spend, and<br/>
        /// privacy-preserving aggregation never exposes clerk_user_id values or per-session rows.<br/>
        /// Filter by `app_slug`, `model`, or `turn_range`. Filtering by `model` alone works across apps<br/>
        /// for harness-vs-harness comparison at a fixed model. Results refresh weekly and include the source snapshot<br/>
        /// window in `meta`.<br/>
        /// Licensed under [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/): reuse and republish with attribution to OpenRouter.
        /// </summary>
        /// <param name="appSlug">
        /// Filter to one published harness slug.<br/>
        /// Example: hermes-agent
        /// </param>
        /// <param name="model">
        /// Exact model permaslug filter. Works across all harness apps.<br/>
        /// Example: anthropic/claude-4.8-opus
        /// </param>
        /// <param name="turnRange">
        /// Filter by the inclusive number of turns in a session.<br/>
        /// Example: 10-49-turns
        /// </param>
        /// <param name="limit">
        /// Maximum number of cells to return (1-500). Defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="offset">
        /// Number of sorted cells to skip (0-5000). Defaults to 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.SessionCostResponse> GetSessionCostAsync(
            string? appSlug = default,
            string? model = default,
            global::OpenRouter.GetSessionCostTurnRange? turnRange = default,
            int? limit = default,
            int? offset = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cost per session by harness and model<br/>
        /// Returns weekly refreshed, aggregated cost-per-session cells for the published harnesses.<br/>
        /// Sessions are never pooled across apps. Medians are of per-session USD spend, and<br/>
        /// privacy-preserving aggregation never exposes clerk_user_id values or per-session rows.<br/>
        /// Filter by `app_slug`, `model`, or `turn_range`. Filtering by `model` alone works across apps<br/>
        /// for harness-vs-harness comparison at a fixed model. Results refresh weekly and include the source snapshot<br/>
        /// window in `meta`.<br/>
        /// Licensed under [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/): reuse and republish with attribution to OpenRouter.
        /// </summary>
        /// <param name="appSlug">
        /// Filter to one published harness slug.<br/>
        /// Example: hermes-agent
        /// </param>
        /// <param name="model">
        /// Exact model permaslug filter. Works across all harness apps.<br/>
        /// Example: anthropic/claude-4.8-opus
        /// </param>
        /// <param name="turnRange">
        /// Filter by the inclusive number of turns in a session.<br/>
        /// Example: 10-49-turns
        /// </param>
        /// <param name="limit">
        /// Maximum number of cells to return (1-500). Defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="offset">
        /// Number of sorted cells to skip (0-5000). Defaults to 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.SessionCostResponse>> GetSessionCostAsResponseAsync(
            string? appSlug = default,
            string? model = default,
            global::OpenRouter.GetSessionCostTurnRange? turnRange = default,
            int? limit = default,
            int? offset = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}