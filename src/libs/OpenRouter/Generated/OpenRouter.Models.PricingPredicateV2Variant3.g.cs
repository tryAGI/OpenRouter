
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PricingPredicateV2Variant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anyOf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.PricingPredicateV2> AnyOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant3" /> class.
        /// </summary>
        /// <param name="anyOf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingPredicateV2Variant3(
            global::System.Collections.Generic.IList<global::OpenRouter.PricingPredicateV2> anyOf)
        {
            this.AnyOf = anyOf ?? throw new global::System.ArgumentNullException(nameof(anyOf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant3" /> class.
        /// </summary>
        public PricingPredicateV2Variant3()
        {
        }

    }
}