
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// RFC 6749 §5.2 error response.<br/>
    /// Example: {"error":"invalid_grant","error_description":"The subject token was not accepted."}
    /// </summary>
    public sealed partial class OAuthErrorResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OAuthErrorResponseErrorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OAuthErrorResponseError Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthErrorResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="errorDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthErrorResponse(
            global::OpenRouter.OAuthErrorResponseError error,
            string errorDescription)
        {
            this.Error = error;
            this.ErrorDescription = errorDescription ?? throw new global::System.ArgumentNullException(nameof(errorDescription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthErrorResponse" /> class.
        /// </summary>
        public OAuthErrorResponse()
        {
        }

    }
}