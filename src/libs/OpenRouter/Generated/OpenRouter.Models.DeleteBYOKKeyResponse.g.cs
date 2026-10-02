
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"deleted":true}
    /// </summary>
    public sealed partial class DeleteBYOKKeyResponse
    {
        /// <summary>
        /// Confirmation that the BYOK credential was deleted.<br/>
        /// Example: true
        /// </summary>
        /// <default>true</default>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool Deleted { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBYOKKeyResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Confirmation that the BYOK credential was deleted.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteBYOKKeyResponse(
            bool deleted = true)
        {
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBYOKKeyResponse" /> class.
        /// </summary>
        public DeleteBYOKKeyResponse()
        {
        }

    }
}