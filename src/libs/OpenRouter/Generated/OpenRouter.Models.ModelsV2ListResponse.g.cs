
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"author":"openai","canonical_slug":"openai/gpt-4","context_length":8192,"created":1687882411,"description":"OpenAI flagship model.","endpoints":[{"created":1687882411,"data_policy":{"retains_prompts":false,"training":false},"id":"gpt-4","inputs":[{"params":{"max_length":{"unit":"token","value":8192}},"pricing":[{"cost_usd":"0.00003","type":"prompt","unit":"token"}],"type":"text"}],"name":"GPT-4","openrouter":{"slug":"openai/gpt-4"},"outputs":[{"max_length":{"unit":"token","value":4096},"params":{"max_tokens":{"type":"unknown"},"temperature":{"type":"unknown"},"tools":{"type":"unknown"}},"pricing":[{"cost_usd":"0.00006","type":"completion","unit":"token"}],"type":"text"}],"provider":{"name":"OpenAI","slug":"openai","tag":"openai"},"schema_version":"2.4"}],"id":"openai/gpt-4","inputs":["text"],"kind":"model","name":"GPT-4","outputs":["text"],"variant":"standard"}],"links":{"next":null},"total_count":1}
    /// </summary>
    public sealed partial class ModelsV2ListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ModelV2> Data { get; set; }

        /// <summary>
        /// Pagination links
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ModelsV2ListResponseLinks Links { get; set; }

        /// <summary>
        /// Number of models that match the request filters, across all pages<br/>
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
        /// Initializes a new instance of the <see cref="ModelsV2ListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="links">
        /// Pagination links
        /// </param>
        /// <param name="totalCount">
        /// Number of models that match the request filters, across all pages<br/>
        /// Example: 150
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsV2ListResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.ModelV2> data,
            global::OpenRouter.ModelsV2ListResponseLinks links,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsV2ListResponse" /> class.
        /// </summary>
        public ModelsV2ListResponse()
        {
        }

    }
}