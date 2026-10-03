
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PricingPredicateV2Variant4
    {
        /// <summary>
        /// Either a parameter predicate (a map of request parameter name to pricing condition) or a composition predicate (`allOf`, `anyOf`, `not`). Recursive; the full JSON Schema is in the Models API V2 schema asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PricingPredicateV2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PricingPredicateV2 Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant4" /> class.
        /// </summary>
        /// <param name="not">
        /// Either a parameter predicate (a map of request parameter name to pricing condition) or a composition predicate (`allOf`, `anyOf`, `not`). Recursive; the full JSON Schema is in the Models API V2 schema asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingPredicateV2Variant4(
            global::OpenRouter.PricingPredicateV2 not)
        {
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant4" /> class.
        /// </summary>
        public PricingPredicateV2Variant4()
        {
        }

    }
}