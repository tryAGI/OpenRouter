
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlignmentCallRecordDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AlignmentCallRecordDiscriminatorOutcomeJsonConverter))]
        public global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome? Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentCallRecordDiscriminator" /> class.
        /// </summary>
        /// <param name="outcome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlignmentCallRecordDiscriminator(
            global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome? outcome)
        {
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentCallRecordDiscriminator" /> class.
        /// </summary>
        public AlignmentCallRecordDiscriminator()
        {
        }

    }
}