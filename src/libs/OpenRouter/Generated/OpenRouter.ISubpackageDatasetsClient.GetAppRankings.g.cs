#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageDatasetsClient
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
        /// traffic flows through a different provider.
        /// </summary>
        /// <param name="category">
        /// Marketplace category group to filter by (e.g. `coding`). Only apps tagged with a subcategory inside this group are returned. Mutually combinable with `subcategory` — when both are supplied the `subcategory` must belong to the `category` group.
        /// </param>
        /// <param name="subcategory">
        /// Marketplace subcategory to filter by (e.g. `cli-agent`). Takes precedence over `category` for the actual filter; when `category` is also supplied the pair must be consistent.
        /// </param>
        /// <param name="sort">
        /// `popular` ranks apps by total token volume inside the date window. `trending` ranks apps by absolute excess token growth: window volume minus the average volume of the three equal-length periods immediately preceding the window. Apps with no excess growth are omitted from `trending` results.<br/>
        /// Default Value: popular
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AppRankingsResponse> GetAppRankingsAsync(
            global::OpenRouter.DatasetsAppRankingsGetParametersCategory? category = default,
            global::OpenRouter.DatasetsAppRankingsGetParametersSubcategory? subcategory = default,
            global::OpenRouter.DatasetsAppRankingsGetParametersSort? sort = default,
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
        /// traffic flows through a different provider.
        /// </summary>
        /// <param name="category">
        /// Marketplace category group to filter by (e.g. `coding`). Only apps tagged with a subcategory inside this group are returned. Mutually combinable with `subcategory` — when both are supplied the `subcategory` must belong to the `category` group.
        /// </param>
        /// <param name="subcategory">
        /// Marketplace subcategory to filter by (e.g. `cli-agent`). Takes precedence over `category` for the actual filter; when `category` is also supplied the pair must be consistent.
        /// </param>
        /// <param name="sort">
        /// `popular` ranks apps by total token volume inside the date window. `trending` ranks apps by absolute excess token growth: window volume minus the average volume of the three equal-length periods immediately preceding the window. Apps with no excess growth are omitted from `trending` results.<br/>
        /// Default Value: popular
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.AppRankingsResponse>> GetAppRankingsAsResponseAsync(
            global::OpenRouter.DatasetsAppRankingsGetParametersCategory? category = default,
            global::OpenRouter.DatasetsAppRankingsGetParametersSubcategory? subcategory = default,
            global::OpenRouter.DatasetsAppRankingsGetParametersSort? sort = default,
            string? startDate = default,
            string? endDate = default,
            int? limit = default,
            int? offset = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}