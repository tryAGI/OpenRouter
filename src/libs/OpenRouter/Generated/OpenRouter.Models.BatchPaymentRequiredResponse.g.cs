
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Batch metadata with results withheld (results: null) plus the standard error envelope. Add credits to unlock the already-computed results; the batch is not re-run.
    /// </summary>
    public sealed partial class BatchPaymentRequiredResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchPaymentRequiredResponseCompletionWindowJsonConverter))]
        public global::OpenRouter.BatchPaymentRequiredResponseCompletionWindow CompletionWindow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchPaymentRequiredResponseError Error { get; set; }

        /// <summary>
        /// Unix timestamp after which the assigned provider no longer completes unfinished requests. Derived from the provider's documented batch window, so it can exceed `created_at` plus `completion_window` (Google Vertex can take up to 96 hours). `null` when the provider documents no hard expiry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalized_at")]
        public int? FinalizedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchPaymentRequiredResponseObjectJsonConverter))]
        public global::OpenRouter.BatchPaymentRequiredResponseObject Object { get; set; }

        /// <summary>
        /// Provider OpenRouter assigned to run the batch, using the same name as the `provider` field of sync responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchPaymentRequiredResponseRequestCounts RequestCounts { get; set; }

        /// <summary>
        /// Always null: results are withheld until the batch charge is covered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public object? Results { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchPaymentRequiredResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchPaymentRequiredResponseStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.BatchPaymentRequiredResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPaymentRequiredResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="endpoint"></param>
        /// <param name="error"></param>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="requestCounts"></param>
        /// <param name="status"></param>
        /// <param name="completionWindow"></param>
        /// <param name="expiresAt">
        /// Unix timestamp after which the assigned provider no longer completes unfinished requests. Derived from the provider's documented batch window, so it can exceed `created_at` plus `completion_window` (Google Vertex can take up to 96 hours). `null` when the provider documents no hard expiry.
        /// </param>
        /// <param name="finalizedAt"></param>
        /// <param name="object"></param>
        /// <param name="provider">
        /// Provider OpenRouter assigned to run the batch, using the same name as the `provider` field of sync responses.
        /// </param>
        /// <param name="results">
        /// Always null: results are withheld until the batch charge is covered.
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchPaymentRequiredResponse(
            int createdAt,
            string endpoint,
            global::OpenRouter.BatchPaymentRequiredResponseError error,
            string id,
            string model,
            global::OpenRouter.BatchPaymentRequiredResponseRequestCounts requestCounts,
            global::OpenRouter.BatchPaymentRequiredResponseStatus status,
            global::OpenRouter.BatchPaymentRequiredResponseCompletionWindow completionWindow,
            global::System.DateTimeOffset? expiresAt,
            int? finalizedAt,
            global::OpenRouter.BatchPaymentRequiredResponseObject @object,
            string? provider,
            object? results,
            global::OpenRouter.BatchPaymentRequiredResponseUsage? usage)
        {
            this.CompletionWindow = completionWindow;
            this.CreatedAt = createdAt;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.ExpiresAt = expiresAt;
            this.FinalizedAt = finalizedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.Provider = provider;
            this.RequestCounts = requestCounts ?? throw new global::System.ArgumentNullException(nameof(requestCounts));
            this.Results = results;
            this.Status = status;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPaymentRequiredResponse" /> class.
        /// </summary>
        public BatchPaymentRequiredResponse()
        {
        }

    }
}