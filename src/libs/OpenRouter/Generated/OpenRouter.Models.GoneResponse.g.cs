
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Gone - Endpoint has been permanently removed or deprecated<br/>
    /// Example: {"error":{"code":410,"message":"The Coinbase APIs used by this endpoint have been deprecated, so the Coinbase Commerce credits API has been removed. Use the web credits purchase flow instead."}}
    /// </summary>
    public sealed partial class GoneResponse
    {
        /// <summary>
        /// Error data for GoneResponse<br/>
        /// Example: {"code":410,"message":"The Coinbase APIs used by this endpoint have been deprecated, so the Coinbase Commerce credits API has been removed. Use the web credits purchase flow instead."}
        /// </summary>
        /// <example>{"code":410,"message":"The Coinbase APIs used by this endpoint have been deprecated, so the Coinbase Commerce credits API has been removed. Use the web credits purchase flow instead."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GoneResponseErrorData Error { get; set; }

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
        /// Initializes a new instance of the <see cref="GoneResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for GoneResponse<br/>
        /// Example: {"code":410,"message":"The Coinbase APIs used by this endpoint have been deprecated, so the Coinbase Commerce credits API has been removed. Use the web credits purchase flow instead."}
        /// </param>
        /// <param name="openrouterMetadata"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoneResponse(
            global::OpenRouter.GoneResponseErrorData error,
            object? openrouterMetadata,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.OpenrouterMetadata = openrouterMetadata;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoneResponse" /> class.
        /// </summary>
        public GoneResponse()
        {
        }

    }
}