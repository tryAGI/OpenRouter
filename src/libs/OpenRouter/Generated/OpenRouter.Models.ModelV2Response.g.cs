
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"author":"openai","canonical_slug":"openai/gpt-4","context_length":8192,"created":1687882411,"description":"OpenAI flagship model.","endpoints":[{"created":1687882411,"data_policy":{"retains_prompts":false,"training":false},"id":"gpt-4","inputs":[{"params":{"max_length":{"unit":"token","value":8192}},"pricing":[{"cost_usd":"0.00003","type":"prompt","unit":"token"}],"type":"text"}],"name":"GPT-4","openrouter":{"slug":"openai/gpt-4"},"outputs":[{"max_length":{"unit":"token","value":4096},"params":{"max_tokens":{"type":"unknown"},"temperature":{"type":"unknown"},"tools":{"type":"unknown"}},"pricing":[{"cost_usd":"0.00006","type":"completion","unit":"token"}],"type":"text"}],"provider":{"name":"OpenAI","slug":"openai","tag":"openai"},"schema_version":"2.4"}],"id":"openai/gpt-4","inputs":["text"],"kind":"model","name":"GPT-4","outputs":["text"],"variant":"standard"}}
    /// </summary>
    public sealed partial class ModelV2Response
    {
        /// <summary>
        /// Example: {"author":"openai","canonical_slug":"openai/gpt-4","context_length":8192,"created":1687882411,"description":"OpenAI flagship model.","endpoints":[{"created":1687882411,"data_policy":{"retains_prompts":false,"training":false},"id":"gpt-4","inputs":[{"params":{"max_length":{"unit":"token","value":8192}},"pricing":[{"cost_usd":"0.00003","type":"prompt","unit":"token"}],"type":"text"}],"name":"GPT-4","openrouter":{"slug":"openai/gpt-4"},"outputs":[{"max_length":{"unit":"token","value":4096},"params":{"max_tokens":{"type":"unknown"},"temperature":{"type":"unknown"},"tools":{"type":"unknown"}},"pricing":[{"cost_usd":"0.00006","type":"completion","unit":"token"}],"type":"text"}],"provider":{"name":"OpenAI","slug":"openai","tag":"openai"},"schema_version":"2.4"}],"id":"openai/gpt-4","inputs":["text"],"kind":"model","name":"GPT-4","outputs":["text"],"variant":"standard"}
        /// </summary>
        /// <example>{"author":"openai","canonical_slug":"openai/gpt-4","context_length":8192,"created":1687882411,"description":"OpenAI flagship model.","endpoints":[{"created":1687882411,"data_policy":{"retains_prompts":false,"training":false},"id":"gpt-4","inputs":[{"params":{"max_length":{"unit":"token","value":8192}},"pricing":[{"cost_usd":"0.00003","type":"prompt","unit":"token"}],"type":"text"}],"name":"GPT-4","openrouter":{"slug":"openai/gpt-4"},"outputs":[{"max_length":{"unit":"token","value":4096},"params":{"max_tokens":{"type":"unknown"},"temperature":{"type":"unknown"},"tools":{"type":"unknown"}},"pricing":[{"cost_usd":"0.00006","type":"completion","unit":"token"}],"type":"text"}],"provider":{"name":"OpenAI","slug":"openai","tag":"openai"},"schema_version":"2.4"}],"id":"openai/gpt-4","inputs":["text"],"kind":"model","name":"GPT-4","outputs":["text"],"variant":"standard"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ModelV2 Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelV2Response" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: {"author":"openai","canonical_slug":"openai/gpt-4","context_length":8192,"created":1687882411,"description":"OpenAI flagship model.","endpoints":[{"created":1687882411,"data_policy":{"retains_prompts":false,"training":false},"id":"gpt-4","inputs":[{"params":{"max_length":{"unit":"token","value":8192}},"pricing":[{"cost_usd":"0.00003","type":"prompt","unit":"token"}],"type":"text"}],"name":"GPT-4","openrouter":{"slug":"openai/gpt-4"},"outputs":[{"max_length":{"unit":"token","value":4096},"params":{"max_tokens":{"type":"unknown"},"temperature":{"type":"unknown"},"tools":{"type":"unknown"}},"pricing":[{"cost_usd":"0.00006","type":"completion","unit":"token"}],"type":"text"}],"provider":{"name":"OpenAI","slug":"openai","tag":"openai"},"schema_version":"2.4"}],"id":"openai/gpt-4","inputs":["text"],"kind":"model","name":"GPT-4","outputs":["text"],"variant":"standard"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelV2Response(
            global::OpenRouter.ModelV2 data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelV2Response" /> class.
        /// </summary>
        public ModelV2Response()
        {
        }

    }
}