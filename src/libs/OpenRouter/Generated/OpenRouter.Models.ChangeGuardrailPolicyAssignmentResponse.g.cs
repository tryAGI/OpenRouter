
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChangeGuardrailPolicyAssignmentResponse
    {
        /// <summary>
        /// Whether the assignment changed<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeGuardrailPolicyAssignmentResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Whether the assignment changed<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChangeGuardrailPolicyAssignmentResponse(
            bool data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeGuardrailPolicyAssignmentResponse" /> class.
        /// </summary>
        public ChangeGuardrailPolicyAssignmentResponse()
        {
        }

    }
}