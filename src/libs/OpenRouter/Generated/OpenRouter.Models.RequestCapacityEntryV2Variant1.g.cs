
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestCapacityEntryV2Variant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.RequestCapacityEntryV2Variant1PerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.RequestCapacityEntryV2Variant1Per Per { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.RequestCapacityEntryV2Variant1TypeJsonConverter))]
        public global::OpenRouter.RequestCapacityEntryV2Variant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.RequestUnitV2JsonConverter))]
        public global::OpenRouter.RequestUnitV2 Unit { get; set; }

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
        /// Initializes a new instance of the <see cref="RequestCapacityEntryV2Variant1" /> class.
        /// </summary>
        /// <param name="per"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="unit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestCapacityEntryV2Variant1(
            global::OpenRouter.RequestCapacityEntryV2Variant1Per per,
            int value,
            global::OpenRouter.RequestCapacityEntryV2Variant1Type type,
            global::OpenRouter.RequestUnitV2 unit)
        {
            this.Per = per;
            this.Type = type;
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCapacityEntryV2Variant1" /> class.
        /// </summary>
        public RequestCapacityEntryV2Variant1()
        {
        }

    }
}