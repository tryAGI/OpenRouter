#nullable enable

namespace OpenRouter
{
    public partial interface IAlphaDecisionsClient
    {
        /// <summary>
        /// Submit a Decisions request<br/>
        /// Asks a Decisions model typed questions (`noul`, `choice`, `score`, `box`) about the content in `state` and returns one typed answer per question with its probabilities. Images, audio and video go in `state` as `image_url`, `input_audio` and `video_url` parts; PNG and JPEG images can instead go once in `assets` and be referenced by key. Which question types, media parts and asset references an endpoint accepts depends on the provider; a request an endpoint cannot serve fails with `400` before anything is sent upstream. See the [Multimodal Decisions guide](/docs/guides/community/multimodal-decisions) for the per-provider table. Typed fields (text, numbers, dates, lists, estimates, forecasts) come from [`POST /api/alpha/extractions`](/docs/guides/community/extractions), which takes the same envelope with `fields` in place of `questions` (text `state` only; images and PDFs go in `assets`). Alpha: the shape may change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DecisionsResponse> CreateAsync(

            global::OpenRouter.DecisionsRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a Decisions request<br/>
        /// Asks a Decisions model typed questions (`noul`, `choice`, `score`, `box`) about the content in `state` and returns one typed answer per question with its probabilities. Images, audio and video go in `state` as `image_url`, `input_audio` and `video_url` parts; PNG and JPEG images can instead go once in `assets` and be referenced by key. Which question types, media parts and asset references an endpoint accepts depends on the provider; a request an endpoint cannot serve fails with `400` before anything is sent upstream. See the [Multimodal Decisions guide](/docs/guides/community/multimodal-decisions) for the per-provider table. Typed fields (text, numbers, dates, lists, estimates, forecasts) come from [`POST /api/alpha/extractions`](/docs/guides/community/extractions), which takes the same envelope with `fields` in place of `questions` (text `state` only; images and PDFs go in `assets`). Alpha: the shape may change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.DecisionsResponse>> CreateAsResponseAsync(

            global::OpenRouter.DecisionsRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a Decisions request<br/>
        /// Asks a Decisions model typed questions (`noul`, `choice`, `score`, `box`) about the content in `state` and returns one typed answer per question with its probabilities. Images, audio and video go in `state` as `image_url`, `input_audio` and `video_url` parts; PNG and JPEG images can instead go once in `assets` and be referenced by key. Which question types, media parts and asset references an endpoint accepts depends on the provider; a request an endpoint cannot serve fails with `400` before anything is sent upstream. See the [Multimodal Decisions guide](/docs/guides/community/multimodal-decisions) for the per-provider table. Typed fields (text, numbers, dates, lists, estimates, forecasts) come from [`POST /api/alpha/extractions`](/docs/guides/community/extractions), which takes the same envelope with `fields` in place of `questions` (text `state` only; images and PDFs go in `assets`). Alpha: the shape may change.
        /// </summary>
        /// <param name="assets">
        /// Images keyed by reference string, as in TypeSafe's API. Write a reference wherever the image belongs in `state`, `instructions`, or `criteria`; every asset must be referenced at least once, or the request fails with `400` naming the unused key. TypeSafe Jev endpoints receive `assets` as written and read a reference as a whole string value or inside longer text. Every other provider has each whole-string reference resolved to an `image_url` part before the request is sent, so it is accepted only where that provider reads `image_url` parts (top-level `state` items), and a reference inside longer text fails with `400`. `image_url` parts and `assets` can be mixed in one request.
        /// </param>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="questions"></param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="state">
        /// The content to evaluate: a plain string, or a JSON object or array of related context.
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DecisionsResponse> CreateAsync(
            string model,
            object questions,
            global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>> state,
            global::System.Collections.Generic.Dictionary<string, global::OpenRouter.DecisionsImageAsset>? assets = default,
            global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? provider = default,
            string? sessionId = default,
            global::OpenRouter.TraceConfig? trace = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}