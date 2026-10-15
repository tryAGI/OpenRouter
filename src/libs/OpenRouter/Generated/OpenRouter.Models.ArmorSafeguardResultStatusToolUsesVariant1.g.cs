
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArmorSafeguardResultStatusToolUsesVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        public string? Explanation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ArmorSafeguardResultStatusToolUsesVariant1OutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1Outcome Outcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ArmorSafeguardResultStatusToolUsesVariant1TypeJsonConverter))]
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorSafeguardResultStatusToolUsesVariant1" /> class.
        /// </summary>
        /// <param name="outcome"></param>
        /// <param name="explanation"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArmorSafeguardResultStatusToolUsesVariant1(
            global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1Outcome outcome,
            string? explanation,
            global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1Type type)
        {
            this.Explanation = explanation;
            this.Outcome = outcome;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorSafeguardResultStatusToolUsesVariant1" /> class.
        /// </summary>
        public ArmorSafeguardResultStatusToolUsesVariant1()
        {
        }

    }
}