
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Task budget for an agentic turn. The model sees a countdown of remaining tokens and uses it to prioritize work and wind down gracefully. Advisory — does not enforce a hard cap.
    /// </summary>
    public sealed partial class MessagesOutputConfigTaskBudget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigTaskBudgetTypeJsonConverter))]
        public global::OpenRouter.MessagesOutputConfigTaskBudgetType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfigTaskBudget" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="remaining"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesOutputConfigTaskBudget(
            int total,
            int? remaining,
            global::OpenRouter.MessagesOutputConfigTaskBudgetType type)
        {
            this.Remaining = remaining;
            this.Total = total;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfigTaskBudget" /> class.
        /// </summary>
        public MessagesOutputConfigTaskBudget()
        {
        }
    }
}