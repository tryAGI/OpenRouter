
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PricingOverrideV2
    {
        /// <summary>
        /// Non-negative decimal number string, e.g. "0.000008"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CostUsd { get; set; }

        /// <summary>
        /// Either a parameter predicate (a map of request parameter name to pricing condition) or a composition predicate (`allOf`, `anyOf`, `not`). Recursive; the full JSON Schema is in the Models API V2 schema asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("when")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PricingPredicateV2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PricingPredicateV2 When { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingOverrideV2" /> class.
        /// </summary>
        /// <param name="costUsd">
        /// Non-negative decimal number string, e.g. "0.000008"
        /// </param>
        /// <param name="when">
        /// Either a parameter predicate (a map of request parameter name to pricing condition) or a composition predicate (`allOf`, `anyOf`, `not`). Recursive; the full JSON Schema is in the Models API V2 schema asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingOverrideV2(
            string costUsd,
            global::OpenRouter.PricingPredicateV2 when)
        {
            this.CostUsd = costUsd ?? throw new global::System.ArgumentNullException(nameof(costUsd));
            this.When = when;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingOverrideV2" /> class.
        /// </summary>
        public PricingOverrideV2()
        {
        }

    }
}