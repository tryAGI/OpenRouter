
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"byok_usage_inference":0.012,"cached_tokens":10,"completion_tokens":125,"date":"2025-08-24","endpoint_id":"550e8400-e29b-41d4-a716-446655440000","model":"openai/gpt-4.1","model_permaslug":"openai/gpt-4.1-2025-04-14","prompt_tokens":50,"provider_name":"OpenAI","reasoning_tokens":25,"requests":5,"usage":0.015}]}
    /// </summary>
    public sealed partial class ActivityResponse
    {
        /// <summary>
        /// List of activity items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ActivityItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of activity items
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.ActivityItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityResponse" /> class.
        /// </summary>
        public ActivityResponse()
        {
        }

    }
}