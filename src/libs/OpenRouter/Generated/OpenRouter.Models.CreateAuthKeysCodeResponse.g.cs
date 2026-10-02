
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"app_id":12345,"created_at":"2025-08-24T10:30:00Z","id":"auth_code_xyz789"}}
    /// </summary>
    public sealed partial class CreateAuthKeysCodeResponse
    {
        /// <summary>
        /// Auth code data<br/>
        /// Example: {"app_id":12345,"created_at":"2025-08-24T10:30:00Z","id":"auth_code_xyz789"}
        /// </summary>
        /// <example>{"app_id":12345,"created_at":"2025-08-24T10:30:00Z","id":"auth_code_xyz789"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CreateAuthKeysCodeResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuthKeysCodeResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Auth code data<br/>
        /// Example: {"app_id":12345,"created_at":"2025-08-24T10:30:00Z","id":"auth_code_xyz789"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAuthKeysCodeResponse(
            global::OpenRouter.CreateAuthKeysCodeResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuthKeysCodeResponse" /> class.
        /// </summary>
        public CreateAuthKeysCodeResponse()
        {
        }

    }
}