
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Single model response<br/>
    /// Example: {"data":{"architecture":{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"},"canonical_slug":"openai/gpt-4","context_length":8192,"created":1692901234,"default_parameters":null,"description":"GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.","expiration_date":null,"id":"openai/gpt-4","knowledge_cutoff":null,"links":{"details":"/api/v1/models/openai/gpt-4/endpoints"},"name":"GPT-4","per_request_limits":null,"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"supported_parameters":["temperature","top_p","max_tokens"],"supported_voices":null,"top_provider":{"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}}}
    /// </summary>
    public sealed partial class ModelResponse
    {
        /// <summary>
        /// Information about an AI model available on OpenRouter<br/>
        /// Example: {"architecture":{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"},"canonical_slug":"openai/gpt-4","context_length":8192,"created":1692901234,"default_parameters":null,"description":"GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.","expiration_date":null,"id":"openai/gpt-4","knowledge_cutoff":null,"links":{"details":"/api/v1/models/openai/gpt-5.4/endpoints"},"name":"GPT-4","per_request_limits":null,"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"reasoning":{"default_effort":"medium","default_enabled":true,"mandatory":false,"supported_efforts":["high","medium","low","minimal"]},"supported_parameters":["temperature","top_p","max_tokens"],"supported_voices":null,"top_provider":{"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}}
        /// </summary>
        /// <example>{"architecture":{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"},"canonical_slug":"openai/gpt-4","context_length":8192,"created":1692901234,"default_parameters":null,"description":"GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.","expiration_date":null,"id":"openai/gpt-4","knowledge_cutoff":null,"links":{"details":"/api/v1/models/openai/gpt-5.4/endpoints"},"name":"GPT-4","per_request_limits":null,"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"reasoning":{"default_effort":"medium","default_enabled":true,"mandatory":false,"supported_efforts":["high","medium","low","minimal"]},"supported_parameters":["temperature","top_p","max_tokens"],"supported_voices":null,"top_provider":{"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.Model Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Information about an AI model available on OpenRouter<br/>
        /// Example: {"architecture":{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"},"canonical_slug":"openai/gpt-4","context_length":8192,"created":1692901234,"default_parameters":null,"description":"GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.","expiration_date":null,"id":"openai/gpt-4","knowledge_cutoff":null,"links":{"details":"/api/v1/models/openai/gpt-5.4/endpoints"},"name":"GPT-4","per_request_limits":null,"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"reasoning":{"default_effort":"medium","default_enabled":true,"mandatory":false,"supported_efforts":["high","medium","low","minimal"]},"supported_parameters":["temperature","top_p","max_tokens"],"supported_voices":null,"top_provider":{"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelResponse(
            global::OpenRouter.Model data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponse" /> class.
        /// </summary>
        public ModelResponse()
        {
        }

    }
}