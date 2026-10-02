#nullable enable

namespace OpenRouter
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Top apps by token usage<br/>
        /// Returns the top public apps on OpenRouter ranked by token usage inside the requested<br/>
        /// date window, matching the public apps marketplace on openrouter.ai/apps. Token totals<br/>
        /// are `prompt_tokens + completion_tokens`; hidden and private apps are excluded and<br/>
        /// traffic from related app aliases is merged into the canonical visible app.<br/>
        /// `sort=popular` (default) ranks by total token volume inside the window.<br/>
        /// `sort=trending` ranks by absolute excess token growth: window volume minus the average<br/>
        /// volume of the three equal-length periods immediately preceding the window. Apps with<br/>
        /// no excess growth are omitted, so `trending` may return fewer than `limit` rows.<br/>
        /// Filter with `category` (marketplace category group, e.g. `coding`) or `subcategory`<br/>
        /// (e.g. `cli-agent`). Ranks are re-numbered 1..N after filtering. Page with `offset` —<br/>
        /// `rank` stays absolute, so the first row of `offset=50` is `rank: 51`.<br/>
        /// Authenticate with any valid OpenRouter API key (same key used for inference).<br/>
        /// Rate-limited to 30 requests/minute per key and 500 requests/day per account.<br/>
        /// When republishing or quoting this dataset, OpenRouter must be cited as:<br/>
        /// "Source: OpenRouter (openrouter.ai/apps), as of {as_of}."<br/>
        /// Token counts come from each upstream provider's own tokenizer, so a token attributed<br/>
        /// to one app is not directly comparable to a token attributed to another app whose<br/>
        /// traffic flows through a different provider.<br/>
        /// Licensed under [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/): reuse and republish with attribution to OpenRouter.
        /// </summary>
        /// <param name="category">
        /// Marketplace category group to filter by (e.g. `coding`). Only apps tagged with a subcategory inside this group are returned. Mutually combinable with `subcategory` — when both are supplied the `subcategory` must belong to the `category` group.<br/>
        /// Example: coding
        /// </param>
        /// <param name="subcategory">
        /// Marketplace subcategory to filter by (e.g. `cli-agent`). Takes precedence over `category` for the actual filter; when `category` is also supplied the pair must be consistent.<br/>
        /// Example: cli-agent
        /// </param>
        /// <param name="sort">
        /// `popular` ranks apps by total token volume inside the date window. `trending` ranks apps by absolute excess token growth: window volume minus the average volume of the three equal-length periods immediately preceding the window. Apps with no excess growth are omitted from `trending` results.<br/>
        /// Default Value: popular<br/>
        /// Example: popular
        /// </param>
        /// <param name="startDate">
        /// Start of the date window in YYYY-MM-DD (UTC), inclusive. Defaults to 30 days before `end_date`. The dataset begins at 2025-01-01; earlier values are clamped forward to that floor and the resolved value is echoed in `meta.start_date`.<br/>
        /// Example: 2026-04-12
        /// </param>
        /// <param name="endDate">
        /// End of the date window in YYYY-MM-DD (UTC), inclusive. Defaults to the most recent completed UTC day. Must be on or after 2025-01-01; earlier values are rejected with a 400.<br/>
        /// Example: 2026-05-11
        /// </param>
        /// <param name="limit">
        /// Maximum number of apps to return (1-100). Defaults to 50.<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="offset">
        /// Number of ranked apps to skip before the first returned row (0-100). Defaults to 0. `rank` stays absolute, so the first row of `offset=50` is `rank: 51`.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AppRankingsResponse> GetAppRankingsAsync(
            global::OpenRouter.GetAppRankingsCategory? category = default,
            global::OpenRouter.GetAppRankingsSubcategory? subcategory = default,
            global::OpenRouter.GetAppRankingsSort? sort = default,
            string? startDate = default,
            string? endDate = default,
            int? limit = default,
            int? offset = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Top apps by token usage<br/>
        /// Returns the top public apps on OpenRouter ranked by token usage inside the requested<br/>
        /// date window, matching the public apps marketplace on openrouter.ai/apps. Token totals<br/>
        /// are `prompt_tokens + completion_tokens`; hidden and private apps are excluded and<br/>
        /// traffic from related app aliases is merged into the canonical visible app.<br/>
        /// `sort=popular` (default) ranks by total token volume inside the window.<br/>
        /// `sort=trending` ranks by absolute excess token growth: window volume minus the average<br/>
        /// volume of the three equal-length periods immediately preceding the window. Apps with<br/>
        /// no excess growth are omitted, so `trending` may return fewer than `limit` rows.<br/>
        /// Filter with `category` (marketplace category group, e.g. `coding`) or `subcategory`<br/>
        /// (e.g. `cli-agent`). Ranks are re-numbered 1..N after filtering. Page with `offset` —<br/>
        /// `rank` stays absolute, so the first row of `offset=50` is `rank: 51`.<br/>
        /// Authenticate with any valid OpenRouter API key (same key used for inference).<br/>
        /// Rate-limited to 30 requests/minute per key and 500 requests/day per account.<br/>
        /// When republishing or quoting this dataset, OpenRouter must be cited as:<br/>
        /// "Source: OpenRouter (openrouter.ai/apps), as of {as_of}."<br/>
        /// Token counts come from each upstream provider's own tokenizer, so a token attributed<br/>
        /// to one app is not directly comparable to a token attributed to another app whose<br/>
        /// traffic flows through a different provider.<br/>
        /// Licensed under [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/): reuse and republish with attribution to OpenRouter.
        /// </summary>
        /// <param name="category">
        /// Marketplace category group to filter by (e.g. `coding`). Only apps tagged with a subcategory inside this group are returned. Mutually combinable with `subcategory` — when both are supplied the `subcategory` must belong to the `category` group.<br/>
        /// Example: coding
        /// </param>
        /// <param name="subcategory">
        /// Marketplace subcategory to filter by (e.g. `cli-agent`). Takes precedence over `category` for the actual filter; when `category` is also supplied the pair must be consistent.<br/>
        /// Example: cli-agent
        /// </param>
        /// <param name="sort">
        /// `popular` ranks apps by total token volume inside the date window. `trending` ranks apps by absolute excess token growth: window volume minus the average volume of the three equal-length periods immediately preceding the window. Apps with no excess growth are omitted from `trending` results.<br/>
        /// Default Value: popular<br/>
        /// Example: popular
        /// </param>
        /// <param name="startDate">
        /// Start of the date window in YYYY-MM-DD (UTC), inclusive. Defaults to 30 days before `end_date`. The dataset begins at 2025-01-01; earlier values are clamped forward to that floor and the resolved value is echoed in `meta.start_date`.<br/>
        /// Example: 2026-04-12
        /// </param>
        /// <param name="endDate">
        /// End of the date window in YYYY-MM-DD (UTC), inclusive. Defaults to the most recent completed UTC day. Must be on or after 2025-01-01; earlier values are rejected with a 400.<br/>
        /// Example: 2026-05-11
        /// </param>
        /// <param name="limit">
        /// Maximum number of apps to return (1-100). Defaults to 50.<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="offset">
        /// Number of ranked apps to skip before the first returned row (0-100). Defaults to 0. `rank` stays absolute, so the first row of `offset=50` is `rank: 51`.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.AppRankingsResponse>> GetAppRankingsAsResponseAsync(
            global::OpenRouter.GetAppRankingsCategory? category = default,
            global::OpenRouter.GetAppRankingsSubcategory? subcategory = default,
            global::OpenRouter.GetAppRankingsSort? sort = default,
            string? startDate = default,
            string? endDate = default,
            int? limit = default,
            int? offset = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}