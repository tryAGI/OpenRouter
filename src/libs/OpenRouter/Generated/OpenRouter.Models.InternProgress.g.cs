
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Active provisioning step, or null once provisioning has settled.
    /// </summary>
    public sealed partial class InternProgress
    {
        /// <summary>
        /// Human-readable label of the active provisioning step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StepLabel { get; set; }

        /// <summary>
        /// One-based index of the active step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StepNumber { get; set; }

        /// <summary>
        /// Number of provisioning steps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSteps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternProgress" /> class.
        /// </summary>
        /// <param name="stepLabel">
        /// Human-readable label of the active provisioning step.
        /// </param>
        /// <param name="stepNumber">
        /// One-based index of the active step.
        /// </param>
        /// <param name="totalSteps">
        /// Number of provisioning steps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternProgress(
            string stepLabel,
            int stepNumber,
            int totalSteps)
        {
            this.StepLabel = stepLabel ?? throw new global::System.ArgumentNullException(nameof(stepLabel));
            this.StepNumber = stepNumber;
            this.TotalSteps = totalSteps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternProgress" /> class.
        /// </summary>
        public InternProgress()
        {
        }

    }
}