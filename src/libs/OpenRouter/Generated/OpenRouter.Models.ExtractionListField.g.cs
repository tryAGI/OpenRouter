
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionListField
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
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionListFieldItemsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ExtractionListFieldItems Items { get; set; }

        /// <summary>
        /// Probability of null above which `value` is null. Default 0.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("null_threshold")]
        public double? NullThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionListFieldTypeJsonConverter))]
        public global::OpenRouter.ExtractionListFieldType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionListField" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="decimals">
        /// Decimal places kept in `value`.
        /// </param>
        /// <param name="instructions">
        /// What the field should contain.
        /// </param>
        /// <param name="nullThreshold">
        /// Probability of null above which `value` is null. Default 0.5.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionListField(
            global::OpenRouter.ExtractionListFieldItems items,
            int? decimals,
            string? instructions,
            double? nullThreshold,
            global::OpenRouter.ExtractionListFieldType type)
        {
            this.Decimals = decimals;
            this.Instructions = instructions;
            this.Items = items;
            this.NullThreshold = nullThreshold;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionListField" /> class.
        /// </summary>
        public ExtractionListField()
        {
        }

    }
}