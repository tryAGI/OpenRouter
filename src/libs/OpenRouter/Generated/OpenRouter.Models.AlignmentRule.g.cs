
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"rule":"Never offer a discount.","watch":["content"]}
    /// </summary>
    public sealed partial class AlignmentRule
    {
        /// <summary>
        /// Text that states what the reply must do or must not do.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rule { get; set; }

        /// <summary>
        /// Fields of the assistant message the rule applies to. The rule is evaluated on a message that has at least one of them and is not applicable to any other message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRuleWatchItem> Watch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentRule" /> class.
        /// </summary>
        /// <param name="rule">
        /// Text that states what the reply must do or must not do.
        /// </param>
        /// <param name="watch">
        /// Fields of the assistant message the rule applies to. The rule is evaluated on a message that has at least one of them and is not applicable to any other message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlignmentRule(
            string rule,
            global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRuleWatchItem> watch)
        {
            this.Rule = rule ?? throw new global::System.ArgumentNullException(nameof(rule));
            this.Watch = watch ?? throw new global::System.ArgumentNullException(nameof(watch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentRule" /> class.
        /// </summary>
        public AlignmentRule()
        {
        }

    }
}