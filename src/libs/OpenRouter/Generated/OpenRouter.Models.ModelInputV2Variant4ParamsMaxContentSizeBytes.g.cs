
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelInputV2Variant4ParamsMaxContentSizeBytes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DescriptorUnitV2JsonConverter))]
        public global::OpenRouter.DescriptorUnitV2? Unit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant4ParamsMaxContentSizeBytes" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInputV2Variant4ParamsMaxContentSizeBytes(
            int value,
            global::OpenRouter.DescriptorUnitV2? unit)
        {
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant4ParamsMaxContentSizeBytes" /> class.
        /// </summary>
        public ModelInputV2Variant4ParamsMaxContentSizeBytes()
        {
        }

    }
}