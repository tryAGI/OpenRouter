
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionDurationField
    {
        /// <summary>
        /// Decimal places kept in `value`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decimals")]
        public int? Decimals { get; set; }

        /// <summary>
        /// What the field should contain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integer")]
        public bool? Integer { get; set; }

        /// <summary>
        /// Probability of null above which `value` is null. Default 0.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("null_threshold")]
        public double? NullThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionDurationFieldTypeJsonConverter))]
        public global::OpenRouter.ExtractionDurationFieldType Type { get; set; }

        /// <summary>
        /// seconds, minutes, hours, days, weeks, months or years.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionDurationField" /> class.
        /// </summary>
        /// <param name="decimals">
        /// Decimal places kept in `value`.
        /// </param>
        /// <param name="instructions">
        /// What the field should contain.
        /// </param>
        /// <param name="integer"></param>
        /// <param name="nullThreshold">
        /// Probability of null above which `value` is null. Default 0.5.
        /// </param>
        /// <param name="type"></param>
        /// <param name="unit">
        /// seconds, minutes, hours, days, weeks, months or years.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionDurationField(
            int? decimals,
            string? instructions,
            bool? integer,
            double? nullThreshold,
            global::OpenRouter.ExtractionDurationFieldType type,
            string? unit)
        {
            this.Decimals = decimals;
            this.Instructions = instructions;
            this.Integer = integer;
            this.NullThreshold = nullThreshold;
            this.Type = type;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionDurationField" /> class.
        /// </summary>
        public ExtractionDurationField()
        {
        }

    }
}