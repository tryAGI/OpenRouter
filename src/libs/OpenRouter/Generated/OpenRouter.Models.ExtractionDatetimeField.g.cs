
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionDatetimeField
    {
        /// <summary>
        /// What the field should contain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Probability of null above which `value` is null. Default 0.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("null_threshold")]
        public double? NullThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionDatetimeFieldTypeJsonConverter))]
        public global::OpenRouter.ExtractionDatetimeFieldType Type { get; set; }

        /// <summary>
        /// Unit label for the value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionDatetimeField" /> class.
        /// </summary>
        /// <param name="instructions">
        /// What the field should contain.
        /// </param>
        /// <param name="nullThreshold">
        /// Probability of null above which `value` is null. Default 0.5.
        /// </param>
        /// <param name="type"></param>
        /// <param name="unit">
        /// Unit label for the value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionDatetimeField(
            string? instructions,
            double? nullThreshold,
            global::OpenRouter.ExtractionDatetimeFieldType type,
            string? unit)
        {
            this.Instructions = instructions;
            this.NullThreshold = nullThreshold;
            this.Type = type;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionDatetimeField" /> class.
        /// </summary>
        public ExtractionDatetimeField()
        {
        }

    }
}