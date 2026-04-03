
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestThinking0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf0TypeJsonConverter))]
        public global::OpenRouter.MessagesRequestThinkingOneOf0Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BudgetTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestThinking0" /> class.
        /// </summary>
        /// <param name="budgetTokens"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestThinking0(
            int budgetTokens,
            global::OpenRouter.MessagesRequestThinkingOneOf0Type type)
        {
            this.Type = type;
            this.BudgetTokens = budgetTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestThinking0" /> class.
        /// </summary>
        public MessagesRequestThinking0()
        {
        }
    }
}