
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Capabilities and limits routing uses for this endpoint. A new endpoint copies them from the public endpoint for the same model and provider, or from the model, and the owner can change them. Rate limits are not part of this object: a private endpoint is billed to its own upstream key, so request limits stay with the provider.<br/>
    /// Example: {"completions":{"chat":true,"text":false},"context_length":128000,"excluded_parameters":["logit_bias"],"inputs":{"audio":false,"base64_files":null,"base64_images":true,"file_urls":null,"image_urls":true},"max_completion_tokens":16384,"max_prompt_tokens":null,"quantization":"bf16","reasoning":{"return_mechanism":"reasoning","supported":true},"tool_choice":{"auto":true,"function":false,"none":true,"required":true}}
    /// </summary>
    public sealed partial class PrivateEndpointSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateEndpointSettingsCompletions Completions { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointSettingsExcludedParameter> ExcludedParameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateEndpointSettingsInputs Inputs { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateEndpointQuantization Quantization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateEndpointSettingsReasoning Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateEndpointSettingsToolChoice ToolChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointSettings" /> class.
        /// </summary>
        /// <param name="completions"></param>
        /// <param name="excludedParameters">
        /// Request parameters the upstream rejects even though the model supports them; requests using one do not route here. Cannot name a tested parameter.<br/>
        /// Example: [logit_bias]
        /// </param>
        /// <param name="inputs"></param>
        /// <param name="quantization">
        /// Weight precision the deployment runs at; `unknown` when not stated.<br/>
        /// Example: bf16
        /// </param>
        /// <param name="reasoning"></param>
        /// <param name="toolChoice"></param>
        /// <param name="contextLength">
        /// Longest prompt plus completion, in tokens, or `null` to keep the model default.<br/>
        /// Example: 128000
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Longest completion the upstream returns, in tokens, or `null` to keep the model default.<br/>
        /// Example: 16384
        /// </param>
        /// <param name="maxPromptTokens">
        /// Longest prompt, in tokens, or `null` for no cap below the context length. Cannot exceed `context_length`, or the model context length while `context_length` is `null`.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointSettings(
            global::OpenRouter.PrivateEndpointSettingsCompletions completions,
            global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointSettingsExcludedParameter> excludedParameters,
            global::OpenRouter.PrivateEndpointSettingsInputs inputs,
            global::OpenRouter.PrivateEndpointQuantization quantization,
            global::OpenRouter.PrivateEndpointSettingsReasoning reasoning,
            global::OpenRouter.PrivateEndpointSettingsToolChoice toolChoice,
            int? contextLength,
            int? maxCompletionTokens,
            int? maxPromptTokens)
        {
            this.Completions = completions ?? throw new global::System.ArgumentNullException(nameof(completions));
            this.ContextLength = contextLength;
            this.ExcludedParameters = excludedParameters ?? throw new global::System.ArgumentNullException(nameof(excludedParameters));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxPromptTokens = maxPromptTokens;
            this.Quantization = quantization;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.ToolChoice = toolChoice ?? throw new global::System.ArgumentNullException(nameof(toolChoice));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointSettings" /> class.
        /// </summary>
        public PrivateEndpointSettings()
        {
        }

    }
}