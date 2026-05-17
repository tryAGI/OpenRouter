
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateBYOKKeyResponse
    {
        /// <summary>
        /// The updated BYOK credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UpdateByokKeyResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBYOKKeyResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The updated BYOK credential.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBYOKKeyResponse(
            global::OpenRouter.UpdateByokKeyResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBYOKKeyResponse" /> class.
        /// </summary>
        public UpdateBYOKKeyResponse()
        {
        }

    }
}