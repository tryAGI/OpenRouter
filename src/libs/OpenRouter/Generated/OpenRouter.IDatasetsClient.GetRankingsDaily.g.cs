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
        /// Optional filters slice the dataset. `period` (`day`/`week`/`month`) sets the time<br/>
        /// grain. `modality` and `context_bucket` narrow the exact dataset by output/input<br/>
        /// modality (or tool-calling activity) and request context length. `category` and<br/>
        /// `language_type` instead read a sampled, upsampled dataset whose `total_tokens` are<br/>
        /// weekly-grain estimates — they cannot be combined with each other or with the exact<br/>
        /// filters, and reject `period=day` with a 400.<br/>
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
        /// <param name="period">
        /// Time grain of each row. `day` (default) returns the per-UTC-day series; `week` buckets by ISO week start; `month` buckets by month start. With `category` or `language_type` only `week` (default) and `month` are available — `day` is rejected with a 400 because those datasets are aggregated weekly. For those sampled datasets `period=month` buckets each week by its week-start month, so totals are approximate at month boundaries.
        /// </param>
        /// <param name="modality">
        /// Restrict to models for a modality surface: `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </param>
        /// <param name="contextBucket">
        /// Restrict to requests whose context length falls in this bucket (`1K`, `10K`, `100K`, `1M`, or `10M`). Exact dataset — cannot be combined with `category` or `language_type`.
        /// </param>
        /// <param name="category">
        /// Restrict to a use-case category (e.g. `programming`, `roleplay`). Sourced from a sampled, upsampled dataset, so `total_tokens` is an estimate and is aggregated weekly (the trailing weekly bucket may include traffic past `end_date`). Cannot be combined with `modality`, `context_bucket`, or `language_type`.
        /// </param>
        /// <param name="languageType">
        /// Restrict to natural-language or programming-language tagged activity. Sourced from a sampled, upsampled dataset, so `total_tokens` is an estimate and is aggregated weekly (the trailing weekly bucket may include traffic past `end_date`). Cannot be combined with `modality`, `context_bucket`, or `category`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.RankingsDailyResponse> GetRankingsDailyAsync(
            string? startDate = default,
            string? endDate = default,
            global::OpenRouter.DatasetsRankingsDailyGetParametersPeriod? period = default,
            global::OpenRouter.DatasetsRankingsDailyGetParametersModality? modality = default,
            global::OpenRouter.DatasetsRankingsDailyGetParametersContextBucket? contextBucket = default,
            global::OpenRouter.DatasetsRankingsDailyGetParametersCategory? category = default,
            global::OpenRouter.DatasetsRankingsDailyGetParametersLanguageType? languageType = default,
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
        /// Optional filters slice the dataset. `period` (`day`/`week`/`month`) sets the time<br/>
        /// grain. `modality` and `context_bucket` narrow the exact dataset by output/input<br/>
        /// modality (or tool-calling activity) and request context length. `category` and<br/>
        /// `language_type` instead read a sampled, upsampled dataset whose `total_tokens` are<br/>
        /// weekly-grain estimates — they cannot be combined with each other or with the exact<br/>
        /// filters, and reject `period=day` with a 400.<br/>
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
        /// <param name="period">
        /// Time grain of each row. `day` (default) returns the per-UTC-day series; `week` buckets by ISO week start; `month` buckets by month start. With `category` or `language_type` only `week` (default) and `month` are available — `day` is rejected with a 400 because those datasets are aggregated weekly. For those sampled datasets `period=month` buckets each week by its week-start month, so totals are approximate at month boundaries.
        /// </param>
        /// <param name="modality">
        /// Restrict to models for a modality surface: `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </param>
        /// <param name="contextBucket">
        /// Restrict to requests whose context length falls in this bucket (`1K`, `10K`, `100K`, `1M`, or `10M`). Exact dataset — cannot be combined with `category` or `language_type`.
        /// </param>
        /// <param name="category">
        /// Restrict to a use-case category (e.g. `programming`, `roleplay`). Sourced from a sampled, upsampled dataset, so `total_tokens` is an estimate and is aggregated weekly (the trailing weekly bucket may include traffic past `end_date`). Cannot be combined with `modality`, `context_bucket`, or `language_type`.
        /// </param>
        /// <param name="languageType">
        /// Restrict to natural-language or programming-language tagged activity. Sourced from a sampled, upsampled dataset, so `total_tokens` is an estimate and is aggregated weekly (the trailing weekly bucket may include traffic past `end_date`). Cannot be combined with `modality`, `context_bucket`, or `category`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.RankingsDailyResponse>> GetRankingsDailyAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            global::OpenRouter.DatasetsRankingsDailyGetParametersPeriod? period = default,
            global::OpenRouter.DatasetsRankingsDailyGetParametersModality? modality = default,
            global::OpenRouter.DatasetsRankingsDailyGetParametersContextBucket? contextBucket = default,
            global::OpenRouter.DatasetsRankingsDailyGetParametersCategory? category = default,
            global::OpenRouter.DatasetsRankingsDailyGetParametersLanguageType? languageType = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}