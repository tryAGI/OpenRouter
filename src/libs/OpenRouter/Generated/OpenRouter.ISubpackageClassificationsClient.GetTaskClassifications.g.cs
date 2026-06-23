#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageClassificationsClient
    {
        /// <summary>
        /// Task classification market share<br/>
        /// Returns the market-share breakdown of OpenRouter traffic by task classification<br/>
        /// (e.g. code generation, web search, summarization) over a trailing time window.<br/>
        /// Each classification reports its share of classified sampled requests (`usage_share`)<br/>
        /// and classified sampled token volume (`token_share`) as fractions between 0 and 1.<br/>
        /// The unclassified `other` bucket is excluded. Absolute volumes are not exposed<br/>
        /// because the underlying data is sampled.<br/>
        /// Each classification also includes a `models` array listing the top models by<br/>
        /// request volume within that classification, with their within-tag usage and token shares.<br/>
        /// Classifications are grouped into macro-categories (Code, Data, Agent, General)<br/>
        /// with aggregate shares provided for each.<br/>
        /// Authenticate with any valid OpenRouter API key (same key used for inference).<br/>
        /// Rate-limited to 30 requests/minute per key and 500 requests/day per account.<br/>
        /// When republishing or quoting this data, cite as:<br/>
        /// "Source: OpenRouter (openrouter.ai/rankings), as of {as_of}."
        /// </summary>
        /// <param name="window">
        /// Trailing time window for the classification data. Currently only `7d` (trailing 7 days) is supported.<br/>
        /// Default Value: 7d
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.TaskClassificationResponse> GetTaskClassificationsAsync(
            global::OpenRouter.ClassificationsTaskGetParametersWindow? window = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Task classification market share<br/>
        /// Returns the market-share breakdown of OpenRouter traffic by task classification<br/>
        /// (e.g. code generation, web search, summarization) over a trailing time window.<br/>
        /// Each classification reports its share of classified sampled requests (`usage_share`)<br/>
        /// and classified sampled token volume (`token_share`) as fractions between 0 and 1.<br/>
        /// The unclassified `other` bucket is excluded. Absolute volumes are not exposed<br/>
        /// because the underlying data is sampled.<br/>
        /// Each classification also includes a `models` array listing the top models by<br/>
        /// request volume within that classification, with their within-tag usage and token shares.<br/>
        /// Classifications are grouped into macro-categories (Code, Data, Agent, General)<br/>
        /// with aggregate shares provided for each.<br/>
        /// Authenticate with any valid OpenRouter API key (same key used for inference).<br/>
        /// Rate-limited to 30 requests/minute per key and 500 requests/day per account.<br/>
        /// When republishing or quoting this data, cite as:<br/>
        /// "Source: OpenRouter (openrouter.ai/rankings), as of {as_of}."
        /// </summary>
        /// <param name="window">
        /// Trailing time window for the classification data. Currently only `7d` (trailing 7 days) is supported.<br/>
        /// Default Value: 7d
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.TaskClassificationResponse>> GetTaskClassificationsAsResponseAsync(
            global::OpenRouter.ClassificationsTaskGetParametersWindow? window = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}