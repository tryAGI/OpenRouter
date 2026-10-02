
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenResponsesResultVariant2
    {
        /// <summary>
        /// Beta. The result of the alignment plugin for this request; the shape may change.<br/>
        /// Example: {"calls":[{"call":1,"outcome":"allowed","rules":[{"broken":false,"probability":0.04}]}]}
        /// </summary>
        /// <example>{"calls":[{"call":1,"outcome":"allowed","rules":[{"broken":false,"probability":0.04}]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        public global::OpenRouter.Alignment? Alignment { get; set; }

        /// <summary>
        /// Error of a failed response; `metadata` carries OpenRouter-specific details.<br/>
        /// Example: {"code":"server_error","message":"Alignment plugin: the reply could not be evaluated: evaluator_error","metadata":{"alignment":{"calls":[{"call":1,"outcome":"unavailable","reason":"evaluator_error"}]}}}
        /// </summary>
        /// <example>{"code":"server_error","message":"Alignment plugin: the reply could not be evaluated: evaluator_error","metadata":{"alignment":{"calls":[{"call":1,"outcome":"unavailable","reason":"evaluator_error"}]}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::OpenRouter.OpenResponsesErrorField? Error { get; set; }

        /// <summary>
        /// Canonical OpenRouter error type, stable across all API formats<br/>
        /// Example: rate_limit_exceeded
        /// </summary>
        /// <example>rate_limit_exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApiErrorTypeJsonConverter))]
        public global::OpenRouter.ApiErrorType? ErrorType { get; set; }

        /// <summary>
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </summary>
        /// <example>{"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter_metadata")]
        public global::OpenRouter.OpenRouterMetadata? OpenrouterMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItems>? Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// Text output configuration including format and verbosity<br/>
        /// Example: {"format":{"type":"text"}}
        /// </summary>
        /// <example>{"format":{"type":"text"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TextExtendedConfigJsonConverter))]
        public global::OpenRouter.TextExtendedConfig? Text { get; set; }

        /// <summary>
        /// Token usage information for the response<br/>
        /// Example: {"cost":0.0012,"cost_details":{"upstream_inference_cost":null,"upstream_inference_input_cost":0.0008,"upstream_inference_output_cost":0.0004},"input_tokens":10,"input_tokens_details":{"cached_tokens":0},"output_tokens":25,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":35}
        /// </summary>
        /// <example>{"cost":0.0012,"cost_details":{"upstream_inference_cost":null,"upstream_inference_input_cost":0.0008,"upstream_inference_output_cost":0.0004},"input_tokens":10,"input_tokens_details":{"cached_tokens":0},"output_tokens":25,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":35}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.AllOf<global::OpenRouter.OpenAIResponsesUsage, global::OpenRouter.UsageVariant12>? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesResultVariant2" /> class.
        /// </summary>
        /// <param name="alignment">
        /// Beta. The result of the alignment plugin for this request; the shape may change.<br/>
        /// Example: {"calls":[{"call":1,"outcome":"allowed","rules":[{"broken":false,"probability":0.04}]}]}
        /// </param>
        /// <param name="error">
        /// Error of a failed response; `metadata` carries OpenRouter-specific details.<br/>
        /// Example: {"code":"server_error","message":"Alignment plugin: the reply could not be evaluated: evaluator_error","metadata":{"alignment":{"calls":[{"call":1,"outcome":"unavailable","reason":"evaluator_error"}]}}}
        /// </param>
        /// <param name="errorType">
        /// Canonical OpenRouter error type, stable across all API formats<br/>
        /// Example: rate_limit_exceeded
        /// </param>
        /// <param name="openrouterMetadata">
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </param>
        /// <param name="output"></param>
        /// <param name="serviceTier"></param>
        /// <param name="text">
        /// Text output configuration including format and verbosity<br/>
        /// Example: {"format":{"type":"text"}}
        /// </param>
        /// <param name="usage">
        /// Token usage information for the response<br/>
        /// Example: {"cost":0.0012,"cost_details":{"upstream_inference_cost":null,"upstream_inference_input_cost":0.0008,"upstream_inference_output_cost":0.0004},"input_tokens":10,"input_tokens_details":{"cached_tokens":0},"output_tokens":25,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":35}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenResponsesResultVariant2(
            global::OpenRouter.Alignment? alignment,
            global::OpenRouter.OpenResponsesErrorField? error,
            global::OpenRouter.ApiErrorType? errorType,
            global::OpenRouter.OpenRouterMetadata? openrouterMetadata,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputItems>? output,
            string? serviceTier,
            global::OpenRouter.TextExtendedConfig? text,
            global::OpenRouter.AllOf<global::OpenRouter.OpenAIResponsesUsage, global::OpenRouter.UsageVariant12>? usage)
        {
            this.Alignment = alignment;
            this.Error = error;
            this.ErrorType = errorType;
            this.OpenrouterMetadata = openrouterMetadata;
            this.Output = output;
            this.ServiceTier = serviceTier;
            this.Text = text;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesResultVariant2" /> class.
        /// </summary>
        public OpenResponsesResultVariant2()
        {
        }

    }
}