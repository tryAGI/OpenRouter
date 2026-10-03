
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PricingPredicateV2Variant1Variant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gte")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Gte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant1Variant2" /> class.
        /// </summary>
        /// <param name="gte"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingPredicateV2Variant1Variant2(
            double gte)
        {
            this.Gte = gte;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant1Variant2" /> class.
        /// </summary>
        public PricingPredicateV2Variant1Variant2()
        {
        }

    }
}