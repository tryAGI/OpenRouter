
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelInputV2Variant2ParamsRole
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModelInputV2Variant2ParamsRoleTypeJsonConverter))]
        public global::OpenRouter.ModelInputV2Variant2ParamsRoleType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ModelInputV2Variant2ParamsRoleValue> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant2ParamsRole" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInputV2Variant2ParamsRole(
            global::System.Collections.Generic.IList<global::OpenRouter.ModelInputV2Variant2ParamsRoleValue> values,
            global::OpenRouter.ModelInputV2Variant2ParamsRoleType type)
        {
            this.Type = type;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInputV2Variant2ParamsRole" /> class.
        /// </summary>
        public ModelInputV2Variant2ParamsRole()
        {
        }

    }
}