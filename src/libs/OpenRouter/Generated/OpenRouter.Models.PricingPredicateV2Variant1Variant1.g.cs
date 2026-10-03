
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PricingPredicateV2Variant1Variant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equals")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<string, double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<string, double?, bool?> EqualsValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant1Variant1" /> class.
        /// </summary>
        /// <param name="equalsValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingPredicateV2Variant1Variant1(
            global::OpenRouter.OneOf<string, double?, bool?> equalsValue)
        {
            this.EqualsValue = equalsValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPredicateV2Variant1Variant1" /> class.
        /// </summary>
        public PricingPredicateV2Variant1Variant1()
        {
        }

    }
}