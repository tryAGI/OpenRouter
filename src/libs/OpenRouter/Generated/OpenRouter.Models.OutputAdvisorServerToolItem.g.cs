
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:advisor server tool output item<br/>
    /// Example: {"id":"st_tmp_abc123","status":"completed","type":"openrouter:advisor"}
    /// </summary>
    public sealed partial class OutputAdvisorServerToolItem
    {
        /// <summary>
        /// The advisor model's response (the advice text returned to the executor).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advice")]
        public string? Advice { get; set; }

        /// <summary>
        /// Error message when the advisor call did not produce advice. Set together with `status: 'failed'` on the terminal item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Provider-safe function name of the specific advisor instance that produced this item (e.g. `openrouter_advisor__1`). Present only when more than one advisor tool is configured; omitted for the default single advisor. Echo this field back unchanged so the advisor's cross-request memory stays namespaced to the correct instance. This identity is positional: it is derived from the index of the advisor entry in the request `tools` array, so clients must keep the order of advisor tool entries stable across requests in a conversation. Reordering or inserting advisor entries shifts these names and causes each advisor's cross-request memory to be attributed to the wrong instance.<br/>
        /// Example: openrouter_advisor__1
        /// </summary>
        /// <example>openrouter_advisor__1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_name")]
        public string? InstanceName { get; set; }

        /// <summary>
        /// Slug of the advisor model that was consulted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The prompt the executor sent to the advisor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FailableToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FailableToolCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputAdvisorServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputAdvisorServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputAdvisorServerToolItem" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="advice">
        /// The advisor model's response (the advice text returned to the executor).
        /// </param>
        /// <param name="error">
        /// Error message when the advisor call did not produce advice. Set together with `status: 'failed'` on the terminal item.
        /// </param>
        /// <param name="id"></param>
        /// <param name="instanceName">
        /// Provider-safe function name of the specific advisor instance that produced this item (e.g. `openrouter_advisor__1`). Present only when more than one advisor tool is configured; omitted for the default single advisor. Echo this field back unchanged so the advisor's cross-request memory stays namespaced to the correct instance. This identity is positional: it is derived from the index of the advisor entry in the request `tools` array, so clients must keep the order of advisor tool entries stable across requests in a conversation. Reordering or inserting advisor entries shifts these names and causes each advisor's cross-request memory to be attributed to the wrong instance.<br/>
        /// Example: openrouter_advisor__1
        /// </param>
        /// <param name="model">
        /// Slug of the advisor model that was consulted.
        /// </param>
        /// <param name="prompt">
        /// The prompt the executor sent to the advisor.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputAdvisorServerToolItem(
            global::OpenRouter.FailableToolCallStatus status,
            string? advice,
            string? error,
            string? id,
            string? instanceName,
            string? model,
            string? prompt,
            global::OpenRouter.OutputAdvisorServerToolItemType type)
        {
            this.Advice = advice;
            this.Error = error;
            this.Id = id;
            this.InstanceName = instanceName;
            this.Model = model;
            this.Prompt = prompt;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputAdvisorServerToolItem" /> class.
        /// </summary>
        public OutputAdvisorServerToolItem()
        {
        }

    }
}