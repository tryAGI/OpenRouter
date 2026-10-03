
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PricingPredicateV2Variant1Variant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant1Variant4" /> class.
        /// </summary>
        /// <param name="minItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingPredicateV2Variant1Variant4(
            int minItems)
        {
            this.MinItems = minItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant1Variant4" /> class.
        /// </summary>
        public PricingPredicateV2Variant1Variant4()
        {
        }

    }
}