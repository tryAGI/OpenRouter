
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArmorRule
    {
        /// <summary>
        /// Stable id, unique within its source; reported as the deciding rule when it fires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// What the rule matches, written for the classifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// Display name shown in verdict explanations; defaults to the id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Probability at or above which the rule counts as matched. Defaults to 0.6 for hard-deny and soft-deny rules and 0.7 for allow rules (an exception needs stronger evidence to clear a matched soft deny).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorRule" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable id, unique within its source; reported as the deciding rule when it fires.
        /// </param>
        /// <param name="instructions">
        /// What the rule matches, written for the classifier.
        /// </param>
        /// <param name="name">
        /// Display name shown in verdict explanations; defaults to the id.
        /// </param>
        /// <param name="threshold">
        /// Probability at or above which the rule counts as matched. Defaults to 0.6 for hard-deny and soft-deny rules and 0.7 for allow rules (an exception needs stronger evidence to clear a matched soft deny).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArmorRule(
            string id,
            string instructions,
            string? name,
            double? threshold)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Name = name;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorRule" /> class.
        /// </summary>
        public ArmorRule()
        {
        }

    }
}