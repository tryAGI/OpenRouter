#nullable enable

namespace OpenRouter
{
    public partial interface IAlphaExtractionsClient
    {
        /// <summary>
        /// Submit an Extractions request<br/>
        /// Extracts, computes, estimates or forecasts typed fields from a state string and image assets using an extraction-style System One model. Alpha: the shape is not stable.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ExtractionsResponse> CreateAsync(

            global::OpenRouter.ExtractionsRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an Extractions request<br/>
        /// Extracts, computes, estimates or forecasts typed fields from a state string and image assets using an extraction-style System One model. Alpha: the shape is not stable.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ExtractionsResponse>> CreateAsResponseAsync(

            global::OpenRouter.ExtractionsRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an Extractions request<br/>
        /// Extracts, computes, estimates or forecasts typed fields from a state string and image assets using an extraction-style System One model. Alpha: the shape is not stable.
        /// </summary>
        /// <param name="assets">
        /// Assets keyed by reference string. Write a reference wherever the asset belongs in `state` or a field `instructions`; every asset must be referenced at least once. A `state` that is exactly the sole asset's key carries no text of its own and is read as file-only. A model that reads either text or a document per request, not both (ScaleDown Extract with a PDF), needs that form: any other text around the key is state text and is rejected with 400.
        /// </param>
        /// <param name="fields">
        /// Map of field name to typed field spec.
        /// </param>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="referenceDate">
        /// ISO date that anchors dates written without a year.
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="state">
        /// The text to read from. May be empty only when the request carries image assets.
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ExtractionsResponse> CreateAsync(
            object fields,
            string model,
            string state,
            global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ExtractionAsset>? assets = default,
            global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? provider = default,
            string? referenceDate = default,
            string? sessionId = default,
            global::OpenRouter.TraceConfig? trace = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}