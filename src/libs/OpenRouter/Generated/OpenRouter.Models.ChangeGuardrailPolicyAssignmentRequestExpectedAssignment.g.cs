
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The assignment state last read for the subject. The request fails with 409 if it changed since.
    /// </summary>
    public sealed partial class ChangeGuardrailPolicyAssignmentRequestExpectedAssignment
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}