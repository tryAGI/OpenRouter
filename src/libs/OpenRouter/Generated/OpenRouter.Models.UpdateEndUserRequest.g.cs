
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"is_active":true}
    /// </summary>
    public sealed partial class UpdateEndUserRequest
    {
        /// <summary>
        /// Registration state only; does not enforce inference access.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndUserRequest" /> class.
        /// </summary>
        /// <param name="isActive">
        /// Registration state only; does not enforce inference access.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEndUserRequest(
            bool isActive)
        {
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEndUserRequest" /> class.
        /// </summary>
        public UpdateEndUserRequest()
        {
        }

    }
}