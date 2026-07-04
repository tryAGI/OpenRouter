#nullable enable

namespace OpenRouter
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Daily token totals for top 50 models<br/>
        /// Returns the top 50 public models per day by total token usage on OpenRouter, plus a<br/>
        /// single aggregated `other` row per day that sums every model outside that top 50.<br/>
        /// Token totals are `prompt_tokens + completion_tokens`, matching the public rankings<br/>
        /// chart on openrouter.ai/rankings.<br/>
        /// Each row is a distinct `(date, model_permaslug)` pair. The `other` row uses the<br/>
        /// reserved permaslug `other` and is always returned last within its date, so callers<br/>
        /// can compute `top-50 traffic / total daily traffic` without a second request.<br/>
        /// Authenticate with any valid OpenRouter API key (same key used for inference).<br/>
        /// Rate-limited to 30 requests/minute per key and 500 requests/day per account.<br/>
        /// When republishing or quoting this dataset, OpenRouter must be cited as:<br/>
        /// "Source: OpenRouter (openrouter.ai/rankings), as of {as_of}."<br/>
        /// Token counts come from each upstream provider's own tokenizer (Anthropic counts<br/>
        /// are as reported by Anthropic, OpenAI counts are as reported by OpenAI, etc.), so<br/>
        /// a token in one row is not directly comparable to a token in another row from a<br/>
        /// different provider.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.RankingsDailyResponse> GetRankingsDailyAsync(
            string? startDate = default,
            string? endDate = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Daily token totals for top 50 models<br/>
        /// Returns the top 50 public models per day by total token usage on OpenRouter, plus a<br/>
        /// single aggregated `other` row per day that sums every model outside that top 50.<br/>
        /// Token totals are `prompt_tokens + completion_tokens`, matching the public rankings<br/>
        /// chart on openrouter.ai/rankings.<br/>
        /// Each row is a distinct `(date, model_permaslug)` pair. The `other` row uses the<br/>
        /// reserved permaslug `other` and is always returned last within its date, so callers<br/>
        /// can compute `top-50 traffic / total daily traffic` without a second request.<br/>
        /// Authenticate with any valid OpenRouter API key (same key used for inference).<br/>
        /// Rate-limited to 30 requests/minute per key and 500 requests/day per account.<br/>
        /// When republishing or quoting this dataset, OpenRouter must be cited as:<br/>
        /// "Source: OpenRouter (openrouter.ai/rankings), as of {as_of}."<br/>
        /// Token counts come from each upstream provider's own tokenizer (Anthropic counts<br/>
        /// are as reported by Anthropic, OpenAI counts are as reported by OpenAI, etc.), so<br/>
        /// a token in one row is not directly comparable to a token in another row from a<br/>
        /// different provider.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.RankingsDailyResponse>> GetRankingsDailyAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}