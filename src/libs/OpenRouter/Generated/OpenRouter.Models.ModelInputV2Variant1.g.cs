
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelInputV2Variant1
    {
        /// <summary>
        /// Entries must be unique by type, unit, and window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacity")]
        public global::System.Collections.Generic.IList<global::OpenRouter.InputCapacityEntryV2>? Capacity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::OpenRouter.ModelInputV2Variant1Params? Params { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passthrough_parameters")]
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ParameterDescriptorV2>? PassthroughParameters { get; set; }

        /// <summary>
        /// Entries must be unique by type together with the qualifier fields (ttl_seconds, implicit, utc_start, utc_end)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::System.Collections.Generic.IList<global::OpenRouter.InputPricingEntryV2>? Pricing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModelInputV2Variant1TypeJsonConverter))]
        public global::OpenRouter.ModelInputV2Variant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant1" /> class.
        /// </summary>
        /// <param name="capacity">
        /// Entries must be unique by type, unit, and window
        /// </param>
        /// <param name="params"></param>
        /// <param name="passthroughParameters"></param>
        /// <param name="pricing">
        /// Entries must be unique by type together with the qualifier fields (ttl_seconds, implicit, utc_start, utc_end)
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInputV2Variant1(
            global::System.Collections.Generic.IList<global::OpenRouter.InputCapacityEntryV2>? capacity,
            global::OpenRouter.ModelInputV2Variant1Params? @params,
            global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ParameterDescriptorV2>? passthroughParameters,
            global::System.Collections.Generic.IList<global::OpenRouter.InputPricingEntryV2>? pricing,
            global::OpenRouter.ModelInputV2Variant1Type type)
        {
            this.Capacity = capacity;
            this.Params = @params;
            this.PassthroughParameters = passthroughParameters;
            this.Pricing = pricing;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant1" /> class.
        /// </summary>
        public ModelInputV2Variant1()
        {
        }

    }
}