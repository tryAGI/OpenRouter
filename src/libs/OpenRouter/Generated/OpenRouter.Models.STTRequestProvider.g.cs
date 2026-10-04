
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider configuration: data policy routing preferences (`zdr`, `data_collection`) and provider-specific passthrough options
    /// </summary>
    public sealed partial class STTRequestProvider
    {
        /// <summary>
        /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
        /// - allow: (default) allow providers which store user data non-transiently and may train on it<br/>
        /// - deny: use only providers which do not collect user data.<br/>
        /// Example: allow
        /// </summary>
        /// <example>allow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.STTRequestProviderDataCollectionJsonConverter))]
        public global::OpenRouter.STTRequestProviderDataCollection? DataCollection { get; set; }

        /// <summary>
        /// Provider-specific options keyed by provider slug. Only options for the matched provider are forwarded; the rest are ignored. Unrecognized keys are silently dropped.<br/>
        /// Example: {"openai":{"max_tokens":1000}}
        /// </summary>
        /// <example>{"openai":{"max_tokens":1000}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::OpenRouter.ProviderOptions? Options { get; set; }

        /// <summary>
        /// Whether to restrict routing to only ZDR (Zero Data Retention) endpoints. When true, only endpoints that do not retain prompts will be used.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("zdr")]
        public bool? Zdr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTRequestProvider" /> class.
        /// </summary>
        /// <param name="dataCollection">
        /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
        /// - allow: (default) allow providers which store user data non-transiently and may train on it<br/>
        /// - deny: use only providers which do not collect user data.<br/>
        /// Example: allow
        /// </param>
        /// <param name="options">
        /// Provider-specific options keyed by provider slug. Only options for the matched provider are forwarded; the rest are ignored. Unrecognized keys are silently dropped.<br/>
        /// Example: {"openai":{"max_tokens":1000}}
        /// </param>
        /// <param name="zdr">
        /// Whether to restrict routing to only ZDR (Zero Data Retention) endpoints. When true, only endpoints that do not retain prompts will be used.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTRequestProvider(
            global::OpenRouter.STTRequestProviderDataCollection? dataCollection,
            global::OpenRouter.ProviderOptions? options,
            bool? zdr)
        {
            this.DataCollection = dataCollection;
            this.Options = options;
            this.Zdr = zdr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTRequestProvider" /> class.
        /// </summary>
        public STTRequestProvider()
        {
        }

    }
}