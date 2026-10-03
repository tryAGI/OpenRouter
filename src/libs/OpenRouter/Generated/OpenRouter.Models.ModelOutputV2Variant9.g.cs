
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelOutputV2Variant9
    {
        /// <summary>
        /// Entries must be unique by type, unit, and window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacity")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputCapacityEntryV2>? Capacity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ParameterDescriptorV2> Params { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passthrough_parameters")]
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ParameterDescriptorV2>? PassthroughParameters { get; set; }

        /// <summary>
        /// Entries must be unique by type together with the qualifier fields (utc_start, utc_end)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputPricingEntryV2>? Pricing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModelOutputV2Variant9TypeJsonConverter))]
        public global::OpenRouter.ModelOutputV2Variant9Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOutputV2Variant9" /> class.
        /// </summary>
        /// <param name="params"></param>
        /// <param name="capacity">
        /// Entries must be unique by type, unit, and window
        /// </param>
        /// <param name="passthroughParameters"></param>
        /// <param name="pricing">
        /// Entries must be unique by type together with the qualifier fields (utc_start, utc_end)
        /// </param>
        /// <param name="streaming"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelOutputV2Variant9(
            global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ParameterDescriptorV2> @params,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputCapacityEntryV2>? capacity,
            global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ParameterDescriptorV2>? passthroughParameters,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputPricingEntryV2>? pricing,
            bool? streaming,
            global::OpenRouter.ModelOutputV2Variant9Type type)
        {
            this.Capacity = capacity;
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
            this.PassthroughParameters = passthroughParameters;
            this.Pricing = pricing;
            this.Streaming = streaming;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOutputV2Variant9" /> class.
        /// </summary>
        public ModelOutputV2Variant9()
        {
        }

    }
}