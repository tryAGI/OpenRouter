
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Generation response<br/>
    /// Example: {"data":{"api_type":"completions","app_id":12345,"cache_discount":null,"cancelled":false,"created_at":"2024-07-15T23:33:19.433273\u002B00:00","data_region":"global","external_user":"user-123","finish_reason":"stop","generation_time":1200,"http_referer":"https://openrouter.ai/","id":"gen-3bhGkxlo4XFrqiabUM7NDtwDzWwG","is_byok":false,"latency":1250,"model":"sao10k/l3-stheno-8b","moderation_latency":50,"native_finish_reason":"stop","native_tokens_cached":3,"native_tokens_completion":25,"native_tokens_completion_images":0,"native_tokens_prompt":10,"native_tokens_reasoning":5,"num_fetches":0,"num_input_audio_prompt":0,"num_media_completion":0,"num_media_prompt":1,"num_search_results":5,"origin":"https://openrouter.ai/","preset_id":"a9e8d400-592a-494f-908c-375efa66cafd","provider_name":"Infermatic","provider_responses":null,"request_id":"req-1727282430-aBcDeFgHiJkLmNoPqRsT","router":"openrouter/auto","service_tier":"priority","session_id":null,"streamed":true,"tokens_completion":25,"tokens_prompt":10,"total_cost":0.0015,"upstream_id":"chatcmpl-791bcf62-080e-4568-87d0-94c72e3b4946","upstream_inference_cost":0.0012,"usage":0.0015,"user_agent":"Mozilla/5.0","web_search_engine":"exa","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}}
    /// </summary>
    public sealed partial class GenerationResponse
    {
        /// <summary>
        /// Generation data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GenerationResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Generation data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponse(
            global::OpenRouter.GenerationResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponse" /> class.
        /// </summary>
        public GenerationResponse()
        {
        }

    }
}