
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"user":"employee_123"}
    /// </summary>
    public sealed partial class CreateEndUserRequest
    {
        /// <summary>
        /// Immutable case-sensitive tracking string supplied as user on inference requests. URL-encode it in resource paths.<br/>
        /// Example: employee_123
        /// </summary>
        /// <example>employee_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndUserRequest" /> class.
        /// </summary>
        /// <param name="user">
        /// Immutable case-sensitive tracking string supplied as user on inference requests. URL-encode it in resource paths.<br/>
        /// Example: employee_123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEndUserRequest(
            string user)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndUserRequest" /> class.
        /// </summary>
        public CreateEndUserRequest()
        {
        }

    }
}