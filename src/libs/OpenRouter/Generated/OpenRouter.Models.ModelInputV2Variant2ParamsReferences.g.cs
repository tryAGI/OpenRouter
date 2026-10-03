
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelInputV2Variant2ParamsReferences
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public int? Max { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public int? Min { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModelInputV2Variant2ParamsReferencesTypeJsonConverter))]
        public global::OpenRouter.ModelInputV2Variant2ParamsReferencesType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DescriptorUnitV2JsonConverter))]
        public global::OpenRouter.DescriptorUnitV2? Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant2ParamsReferences" /> class.
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="type"></param>
        /// <param name="unit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInputV2Variant2ParamsReferences(
            int? max,
            int? min,
            global::OpenRouter.ModelInputV2Variant2ParamsReferencesType type,
            global::OpenRouter.DescriptorUnitV2? unit)
        {
            this.Max = max;
            this.Min = min;
            this.Type = type;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant2ParamsReferences" /> class.
        /// </summary>
        public ModelInputV2Variant2ParamsReferences()
        {
        }

    }
}