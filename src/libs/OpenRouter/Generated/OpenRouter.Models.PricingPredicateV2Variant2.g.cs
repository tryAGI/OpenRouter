
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PricingPredicateV2Variant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allOf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.PricingPredicateV2> AllOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant2" /> class.
        /// </summary>
        /// <param name="allOf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingPredicateV2Variant2(
            global::System.Collections.Generic.IList<global::OpenRouter.PricingPredicateV2> allOf)
        {
            this.AllOf = allOf ?? throw new global::System.ArgumentNullException(nameof(allOf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant2" /> class.
        /// </summary>
        public PricingPredicateV2Variant2()
        {
        }

    }
}