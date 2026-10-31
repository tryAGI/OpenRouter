
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionsRequest
    {
        /// <summary>
        /// Assets keyed by reference string. Write a reference wherever the asset belongs in `state` or a field `instructions`; every asset must be referenced at least once. A `state` that is exactly the sole asset's key carries no text of its own and is read as file-only. A model that reads either text or a document per request, not both (ScaleDown Extract with a PDF), needs that form: any other text around the key is state text and is rejected with 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ExtractionAsset>? Assets { get; set; }

        /// <summary>
        /// Map of field name to typed field spec.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Fields { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.ProviderPreferences, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? Provider { get; set; }

        /// <summary>
        /// ISO date that anchors dates written without a year.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_date")]
        public string? ReferenceDate { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </summary>
        /// <example>session-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The text to read from. May be empty only when the request carries image assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </summary>
        /// <example>{"trace_id":"trace-abc123","trace_name":"my-app-trace"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::OpenRouter.TraceConfig? Trace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionsRequest" /> class.
        /// </summary>
        /// <param name="fields">
        /// Map of field name to typed field spec.
        /// </param>
        /// <param name="model"></param>
        /// <param name="state">
        /// The text to read from. May be empty only when the request carries image assets.
        /// </param>
        /// <param name="assets">
        /// Assets keyed by reference string. Write a reference wherever the asset belongs in `state` or a field `instructions`; every asset must be referenced at least once. A `state` that is exactly the sole asset's key carries no text of its own and is read as file-only. A model that reads either text or a document per request, not both (ScaleDown Extract with a PDF), needs that form: any other text around the key is state text and is rejected with 400.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="referenceDate">
        /// ISO date that anchors dates written without a year.
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionsRequest(
            object fields,
            string model,
            string state,
            global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ExtractionAsset>? assets,
            global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? provider,
            string? referenceDate,
            string? sessionId,
            global::OpenRouter.TraceConfig? trace,
            string? user)
        {
            this.Assets = assets;
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.ReferenceDate = referenceDate;
            this.SessionId = sessionId;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Trace = trace;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionsRequest" /> class.
        /// </summary>
        public ExtractionsRequest()
        {
        }

    }
}