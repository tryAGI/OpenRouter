
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:advisor server tool output item
    /// </summary>
    public sealed partial class OutputItemsVariant9
    {
        /// <summary>
        /// Discriminator value: openrouter:advisor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsVariant9TypeJsonConverter))]
        public global::OpenRouter.OutputItemsVariant9Type Type { get; set; }

        /// <summary>
        /// The advisor model's response (the advice text returned to the executor).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advice")]
        public string? Advice { get; set; }

        /// <summary>
        /// Error message when the advisor call did not produce advice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant9" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type">
        /// Discriminator value: openrouter:advisor
        /// </param>
        /// <param name="advice">
        /// The advisor model's response (the advice text returned to the executor).
        /// </param>
        /// <param name="error">
        /// Error message when the advisor call did not produce advice.
        /// </param>
        /// <param name="id"></param>
        /// <param name="model">
        /// Slug of the advisor model that was consulted.
        /// </param>
        /// <param name="prompt">
        /// The prompt the executor sent to the advisor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant9(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputItemsVariant9Type type,
            string? advice,
            string? error,
            string? id,
            string? model,
            string? prompt)
        {
            this.Type = type;
            this.Advice = advice;
            this.Error = error;
            this.Id = id;
            this.Model = model;
            this.Prompt = prompt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant9" /> class.
        /// </summary>
        public OutputItemsVariant9()
        {
        }

    }
}