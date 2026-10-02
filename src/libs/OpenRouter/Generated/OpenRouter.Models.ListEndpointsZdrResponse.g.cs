
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"context_length":8192,"latency_last_30m":{"p50":0.25,"p75":0.35,"p90":0.48,"p99":0.85},"max_completion_tokens":4096,"max_prompt_tokens":8192,"model_id":"openai/gpt-4","model_name":"GPT-4","name":"OpenAI: GPT-4","native_tools":{},"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"provider_name":"OpenAI","quantization":"fp16","status":0,"supported_parameters":["temperature","top_p","max_tokens"],"supports_image_reference":false,"supports_implicit_caching":true,"supports_multiple_audio_references":false,"supports_voice_cloning":false,"tag":"openai","throughput_last_30m":{"p50":45.2,"p75":38.5,"p90":28.3,"p99":15.1},"uptime_last_1d":99.8,"uptime_last_30m":99.5,"uptime_last_5m":100}]}
    /// </summary>
    public sealed partial class ListEndpointsZdrResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.PublicEndpoint> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsZdrResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEndpointsZdrResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.PublicEndpoint> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsZdrResponse" /> class.
        /// </summary>
        public ListEndpointsZdrResponse()
        {
        }

    }
}