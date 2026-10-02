
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider Overloaded - Provider is temporarily overloaded<br/>
    /// Example: {"error":{"code":529,"message":"Provider returned error"}}
    /// </summary>
    public sealed partial class ProviderOverloadedResponse
    {
        /// <summary>
        /// Error data for ProviderOverloadedResponse<br/>
        /// Example: {"code":529,"message":"Provider returned error"}
        /// </summary>
        /// <example>{"code":529,"message":"Provider returned error"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ProviderOverloadedResponseErrorData Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter_metadata")]
        public object? OpenrouterMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderOverloadedResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for ProviderOverloadedResponse<br/>
        /// Example: {"code":529,"message":"Provider returned error"}
        /// </param>
        /// <param name="openrouterMetadata"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderOverloadedResponse(
            global::OpenRouter.ProviderOverloadedResponseErrorData error,
            object? openrouterMetadata,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.OpenrouterMetadata = openrouterMetadata;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderOverloadedResponse" /> class.
        /// </summary>
        public ProviderOverloadedResponse()
        {
        }

    }
}