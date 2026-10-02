
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Batch submit request body.
    /// </summary>
    public sealed partial class BatchSubmitBody
    {
        /// <summary>
        /// Default Value: 24h
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchSubmitBodyCompletionWindowJsonConverter))]
        public global::OpenRouter.BatchSubmitBodyCompletionWindow? CompletionWindow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchSubmitBodyEndpointJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchSubmitBodyEndpoint Endpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Batch provider routing preferences. Only `provider.only` is supported.<br/>
        /// Example: {"only":["google-vertex"]}
        /// </summary>
        /// <example>{"only":["google-vertex"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.BatchProviderPreferences? Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.BatchSubmitBodyRequest> Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSubmitBody" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="model"></param>
        /// <param name="requests"></param>
        /// <param name="completionWindow">
        /// Default Value: 24h
        /// </param>
        /// <param name="provider">
        /// Batch provider routing preferences. Only `provider.only` is supported.<br/>
        /// Example: {"only":["google-vertex"]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchSubmitBody(
            global::OpenRouter.BatchSubmitBodyEndpoint endpoint,
            string model,
            global::System.Collections.Generic.IList<global::OpenRouter.BatchSubmitBodyRequest> requests,
            global::OpenRouter.BatchSubmitBodyCompletionWindow? completionWindow,
            global::OpenRouter.BatchProviderPreferences? provider)
        {
            this.CompletionWindow = completionWindow;
            this.Endpoint = endpoint;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSubmitBody" /> class.
        /// </summary>
        public BatchSubmitBody()
        {
        }

    }
}