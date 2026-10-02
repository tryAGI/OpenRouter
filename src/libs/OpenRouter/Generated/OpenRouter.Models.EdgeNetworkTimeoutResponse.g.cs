
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Infrastructure Timeout - Provider request timed out at edge network<br/>
    /// Example: {"error":{"code":524,"message":"Request timed out. Please try again later."}}
    /// </summary>
    public sealed partial class EdgeNetworkTimeoutResponse
    {
        /// <summary>
        /// Error data for EdgeNetworkTimeoutResponse<br/>
        /// Example: {"code":524,"message":"Request timed out. Please try again later."}
        /// </summary>
        /// <example>{"code":524,"message":"Request timed out. Please try again later."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.EdgeNetworkTimeoutResponseErrorData Error { get; set; }

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
        /// Initializes a new instance of the <see cref="EdgeNetworkTimeoutResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for EdgeNetworkTimeoutResponse<br/>
        /// Example: {"code":524,"message":"Request timed out. Please try again later."}
        /// </param>
        /// <param name="openrouterMetadata"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EdgeNetworkTimeoutResponse(
            global::OpenRouter.EdgeNetworkTimeoutResponseErrorData error,
            object? openrouterMetadata,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.OpenrouterMetadata = openrouterMetadata;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeNetworkTimeoutResponse" /> class.
        /// </summary>
        public EdgeNetworkTimeoutResponse()
        {
        }

    }
}