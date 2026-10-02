
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesRequestThinkingVariant1
    {
        /// <summary>
        /// Example: {"prefix_mismatch_behavior":"drop_block"}
        /// </summary>
        /// <example>{"prefix_mismatch_behavior":"drop_block"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_binding")]
        public global::OpenRouter.AnthropicThinkingBlockBinding? BlockBinding { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BudgetTokens { get; set; }

        /// <summary>
        /// Example: summarized
        /// </summary>
        /// <example>summarized</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicThinkingDisplayJsonConverter))]
        public global::OpenRouter.AnthropicThinkingDisplay? Display { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingVariant1TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestThinkingVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestThinkingVariant1" /> class.
        /// </summary>
        /// <param name="budgetTokens"></param>
        /// <param name="blockBinding">
        /// Example: {"prefix_mismatch_behavior":"drop_block"}
        /// </param>
        /// <param name="display">
        /// Example: summarized
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestThinkingVariant1(
            int budgetTokens,
            global::OpenRouter.AnthropicThinkingBlockBinding? blockBinding,
            global::OpenRouter.AnthropicThinkingDisplay? display,
            global::OpenRouter.MessagesRequestThinkingVariant1Type type)
        {
            this.BlockBinding = blockBinding;
            this.BudgetTokens = budgetTokens;
            this.Display = display;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestThinkingVariant1" /> class.
        /// </summary>
        public MessagesRequestThinkingVariant1()
        {
        }

    }
}