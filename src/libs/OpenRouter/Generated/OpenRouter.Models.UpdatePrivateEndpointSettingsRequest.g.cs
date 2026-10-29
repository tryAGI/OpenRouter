
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Capabilities and limits to set over the ones copied from the public endpoint for this model and provider (or from the model). Omitted fields keep the copied values.<br/>
    /// Example: {"context_length":128000,"reasoning":{"supported":true}}
    /// </summary>
    public sealed partial class UpdatePrivateEndpointSettingsRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completions")]
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestCompletions? Completions { get; set; }

        /// <summary>
        /// Longest prompt plus completion, in tokens, or `null` to keep the model default.<br/>
        /// Example: 128000
        /// </summary>
        /// <example>128000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public int? ContextLength { get; set; }

        /// <summary>
        /// Request parameters the upstream rejects even though the model supports them; requests using one do not route here. Cannot name a tested parameter.<br/>
        /// Example: [logit_bias]
        /// </summary>
        /// <example>[logit_bias]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_parameters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter>? ExcludedParameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestInputs? Inputs { get; set; }

        /// <summary>
        /// Longest completion the upstream returns, in tokens, or `null` to keep the model default.<br/>
        /// Example: 16384
        /// </summary>
        /// <example>16384</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Longest prompt, in tokens, or `null` for no cap below the context length. Cannot exceed `context_length`, or the model context length while `context_length` is `null`.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_tokens")]
        public int? MaxPromptTokens { get; set; }

        /// <summary>
        /// Weight precision the deployment runs at; `unknown` when not stated.<br/>
        /// Example: bf16
        /// </summary>
        /// <example>bf16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PrivateEndpointQuantizationJsonConverter))]
        public global::OpenRouter.PrivateEndpointQuantization? Quantization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestReasoning? Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointSettingsRequest" /> class.
        /// </summary>
        /// <param name="completions"></param>
        /// <param name="contextLength">
        /// Longest prompt plus completion, in tokens, or `null` to keep the model default.<br/>
        /// Example: 128000
        /// </param>
        /// <param name="excludedParameters">
        /// Request parameters the upstream rejects even though the model supports them; requests using one do not route here. Cannot name a tested parameter.<br/>
        /// Example: [logit_bias]
        /// </param>
        /// <param name="inputs"></param>
        /// <param name="maxCompletionTokens">
        /// Longest completion the upstream returns, in tokens, or `null` to keep the model default.<br/>
        /// Example: 16384
        /// </param>
        /// <param name="maxPromptTokens">
        /// Longest prompt, in tokens, or `null` for no cap below the context length. Cannot exceed `context_length`, or the model context length while `context_length` is `null`.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="quantization">
        /// Weight precision the deployment runs at; `unknown` when not stated.<br/>
        /// Example: bf16
        /// </param>
        /// <param name="reasoning"></param>
        /// <param name="toolChoice"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrivateEndpointSettingsRequest(
            global::OpenRouter.UpdatePrivateEndpointSettingsRequestCompletions? completions,
            int? contextLength,
            global::System.Collections.Generic.IList<global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter>? excludedParameters,
            global::OpenRouter.UpdatePrivateEndpointSettingsRequestInputs? inputs,
            int? maxCompletionTokens,
            int? maxPromptTokens,
            global::OpenRouter.PrivateEndpointQuantization? quantization,
            global::OpenRouter.UpdatePrivateEndpointSettingsRequestReasoning? reasoning,
            global::OpenRouter.UpdatePrivateEndpointSettingsRequestToolChoice? toolChoice)
        {
            this.Completions = completions;
            this.ContextLength = contextLength;
            this.ExcludedParameters = excludedParameters;
            this.Inputs = inputs;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxPromptTokens = maxPromptTokens;
            this.Quantization = quantization;
            this.Reasoning = reasoning;
            this.ToolChoice = toolChoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointSettingsRequest" /> class.
        /// </summary>
        public UpdatePrivateEndpointSettingsRequest()
        {
        }

    }
}