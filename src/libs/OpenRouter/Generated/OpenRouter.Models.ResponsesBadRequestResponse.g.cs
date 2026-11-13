
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Bad Request - Invalid request parameters or malformed input. Request-shape validation failures carry a Responses API string code (e.g. `invalid_prompt`) with details in the top-level `metadata`; all other failures carry the integer HTTP status.<br/>
    /// Example: {"error":{"code":"invalid_prompt","message":"Invalid Responses API request"},"metadata":{"raw":"[{\u0022code\u0022:\u0022invalid_value\u0022,\u0022path\u0022:[\u0022input\u0022,0,\u0022type\u0022]}]"}}
    /// </summary>
    public sealed partial class ResponsesBadRequestResponse
    {
        /// <summary>
        /// Error data for ResponsesBadRequestResponse<br/>
        /// Example: {"code":"invalid_prompt","message":"Invalid Responses API request"}
        /// </summary>
        /// <example>{"code":"invalid_prompt","message":"Invalid Responses API request"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ResponsesBadRequestResponseErrorData Error { get; set; }

        /// <summary>
        /// Validation details for string-coded errors; `raw` holds the serialized schema issues<br/>
        /// Example: {"raw":"[{\u0022code\u0022:\u0022invalid_value\u0022,\u0022path\u0022:[\u0022input\u0022,0,\u0022type\u0022]}]"}
        /// </summary>
        /// <example>{"raw":"[{\u0022code\u0022:\u0022invalid_value\u0022,\u0022path\u0022:[\u0022input\u0022,0,\u0022type\u0022]}]"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponsesBadRequestResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for ResponsesBadRequestResponse<br/>
        /// Example: {"code":"invalid_prompt","message":"Invalid Responses API request"}
        /// </param>
        /// <param name="metadata">
        /// Validation details for string-coded errors; `raw` holds the serialized schema issues<br/>
        /// Example: {"raw":"[{\u0022code\u0022:\u0022invalid_value\u0022,\u0022path\u0022:[\u0022input\u0022,0,\u0022type\u0022]}]"}
        /// </param>
        /// <param name="openrouterMetadata"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesBadRequestResponse(
            global::OpenRouter.ResponsesBadRequestResponseErrorData error,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            object? openrouterMetadata,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Metadata = metadata;
            this.OpenrouterMetadata = openrouterMetadata;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesBadRequestResponse" /> class.
        /// </summary>
        public ResponsesBadRequestResponse()
        {
        }

    }
}