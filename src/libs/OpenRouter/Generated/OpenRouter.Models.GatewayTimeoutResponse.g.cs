
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Gateway Timeout - Provider did not respond before the upstream deadline<br/>
    /// Example: {"error":{"code":504,"message":"The operation was aborted due to timeout"}}
    /// </summary>
    public sealed partial class GatewayTimeoutResponse
    {
        /// <summary>
        /// Error data for GatewayTimeoutResponse<br/>
        /// Example: {"code":504,"message":"The operation was aborted due to timeout"}
        /// </summary>
        /// <example>{"code":504,"message":"The operation was aborted due to timeout"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GatewayTimeoutResponseErrorData Error { get; set; }

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
        /// Initializes a new instance of the <see cref="GatewayTimeoutResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for GatewayTimeoutResponse<br/>
        /// Example: {"code":504,"message":"The operation was aborted due to timeout"}
        /// </param>
        /// <param name="openrouterMetadata"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayTimeoutResponse(
            global::OpenRouter.GatewayTimeoutResponseErrorData error,
            object? openrouterMetadata,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.OpenrouterMetadata = openrouterMetadata;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayTimeoutResponse" /> class.
        /// </summary>
        public GatewayTimeoutResponse()
        {
        }

    }
}