
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// List of available models<br/>
    /// Example: {"data":[{"architecture":{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"},"canonical_slug":"openai/gpt-4","context_length":8192,"created":1692901234,"default_parameters":null,"description":"GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.","expiration_date":null,"id":"openai/gpt-4","knowledge_cutoff":null,"links":{"details":"/api/v1/models/openai/gpt-4/endpoints"},"name":"GPT-4","per_request_limits":null,"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"supported_parameters":["temperature","top_p","max_tokens","frequency_penalty","presence_penalty"],"supported_voices":null,"top_provider":{"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}}],"links":{"next":"/api/v1/models?offset=500\u0026limit=500"},"total_count":150}
    /// </summary>
    public sealed partial class ModelsListResponse
    {
        /// <summary>
        /// List of available models<br/>
        /// Example: [{"architecture":{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"},"canonical_slug":"openai/gpt-4","context_length":8192,"created":1692901234,"default_parameters":null,"description":"GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.","expiration_date":null,"id":"openai/gpt-4","knowledge_cutoff":null,"links":{"details":"/api/v1/models/openai/gpt-4/endpoints"},"name":"GPT-4","per_request_limits":null,"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"supported_parameters":["temperature","top_p","max_tokens"],"supported_voices":null,"top_provider":{"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}}]
        /// </summary>
        /// <example>[{"architecture":{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"},"canonical_slug":"openai/gpt-4","context_length":8192,"created":1692901234,"default_parameters":null,"description":"GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.","expiration_date":null,"id":"openai/gpt-4","knowledge_cutoff":null,"links":{"details":"/api/v1/models/openai/gpt-4/endpoints"},"name":"GPT-4","per_request_limits":null,"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"supported_parameters":["temperature","top_p","max_tokens"],"supported_voices":null,"top_provider":{"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.Model> Data { get; set; }

        /// <summary>
        /// Pagination links
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ModelsListResponseLinks Links { get; set; }

        /// <summary>
        /// Total number of models matching the query<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of available models<br/>
        /// Example: [{"architecture":{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"},"canonical_slug":"openai/gpt-4","context_length":8192,"created":1692901234,"default_parameters":null,"description":"GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.","expiration_date":null,"id":"openai/gpt-4","knowledge_cutoff":null,"links":{"details":"/api/v1/models/openai/gpt-4/endpoints"},"name":"GPT-4","per_request_limits":null,"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"supported_parameters":["temperature","top_p","max_tokens"],"supported_voices":null,"top_provider":{"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}}]
        /// </param>
        /// <param name="links">
        /// Pagination links
        /// </param>
        /// <param name="totalCount">
        /// Total number of models matching the query<br/>
        /// Example: 150
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsListResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.Model> data,
            global::OpenRouter.ModelsListResponseLinks links,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsListResponse" /> class.
        /// </summary>
        public ModelsListResponse()
        {
        }

    }
}