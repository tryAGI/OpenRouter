
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelInputV2Variant2ParamsDetailLevels
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModelInputV2Variant2ParamsDetailLevelsTypeJsonConverter))]
        public global::OpenRouter.ModelInputV2Variant2ParamsDetailLevelsType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ModelInputV2Variant2ParamsDetailLevelsValue> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant2ParamsDetailLevels" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInputV2Variant2ParamsDetailLevels(
            global::System.Collections.Generic.IList<global::OpenRouter.ModelInputV2Variant2ParamsDetailLevelsValue> values,
            global::OpenRouter.ModelInputV2Variant2ParamsDetailLevelsType type)
        {
            this.Type = type;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant2ParamsDetailLevels" /> class.
        /// </summary>
        public ModelInputV2Variant2ParamsDetailLevels()
        {
        }

    }
}