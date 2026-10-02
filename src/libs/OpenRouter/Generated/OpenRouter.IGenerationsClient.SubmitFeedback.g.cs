#nullable enable

namespace OpenRouter
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Submit feedback for a generation<br/>
        /// Submit structured feedback on a generation the authenticated user made. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.SubmitGenerationFeedbackResponse> SubmitFeedbackAsync(

            global::OpenRouter.SubmitGenerationFeedbackRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit feedback for a generation<br/>
        /// Submit structured feedback on a generation the authenticated user made. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.SubmitGenerationFeedbackResponse>> SubmitFeedbackAsResponseAsync(

            global::OpenRouter.SubmitGenerationFeedbackRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit feedback for a generation<br/>
        /// Submit structured feedback on a generation the authenticated user made. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="category">
        /// The category of feedback being reported<br/>
        /// Example: incorrect_response
        /// </param>
        /// <param name="comment">
        /// An optional free-text comment describing the feedback<br/>
        /// Example: The model repeated the same paragraph three times.
        /// </param>
        /// <param name="generationId">
        /// The generation to submit feedback on<br/>
        /// Example: gen-3bhGkxlo4XFrqiabUM7NDtwDzWwG
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.SubmitGenerationFeedbackResponse> SubmitFeedbackAsync(
            global::OpenRouter.SubmitGenerationFeedbackRequestCategory category,
            string generationId,
            string? comment = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}