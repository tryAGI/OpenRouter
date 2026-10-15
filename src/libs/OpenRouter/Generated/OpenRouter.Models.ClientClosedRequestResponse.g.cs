
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Client Closed Request - The caller cancelled the request<br/>
    /// Example: {"error":{"code":499,"message":"The request was cancelled."}}
    /// </summary>
    public sealed partial class ClientClosedRequestResponse
    {
        /// <summary>
        /// Error data for ClientClosedRequestResponse<br/>
        /// Example: {"code":499,"message":"The request was cancelled."}
        /// </summary>
        /// <example>{"code":499,"message":"The request was cancelled."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ClientClosedRequestResponseErrorData Error { get; set; }

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
        /// Initializes a new instance of the <see cref="ClientClosedRequestResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for ClientClosedRequestResponse<br/>
        /// Example: {"code":499,"message":"The request was cancelled."}
        /// </param>
        /// <param name="openrouterMetadata"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientClosedRequestResponse(
            global::OpenRouter.ClientClosedRequestResponseErrorData error,
            object? openrouterMetadata,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.OpenrouterMetadata = openrouterMetadata;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientClosedRequestResponse" /> class.
        /// </summary>
        public ClientClosedRequestResponse()
        {
        }

    }
}