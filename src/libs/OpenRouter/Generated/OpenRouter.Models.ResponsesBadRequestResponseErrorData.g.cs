
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Error data for ResponsesBadRequestResponse<br/>
    /// Example: {"code":"invalid_prompt","message":"Invalid Responses API request"}
    /// </summary>
    public sealed partial class ResponsesBadRequestResponseErrorData
    {
        /// <summary>
        /// Integer HTTP status, or a Responses API error code string (e.g. `invalid_prompt`) when the request body fails validation<br/>
        /// Example: invalid_prompt
        /// </summary>
        /// <example>invalid_prompt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<int?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<int?, string> Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesBadRequestResponseErrorData" /> class.
        /// </summary>
        /// <param name="code">
        /// Integer HTTP status, or a Responses API error code string (e.g. `invalid_prompt`) when the request body fails validation<br/>
        /// Example: invalid_prompt
        /// </param>
        /// <param name="message"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesBadRequestResponseErrorData(
            global::OpenRouter.AnyOf<int?, string> code,
            string message,
            object? metadata)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesBadRequestResponseErrorData" /> class.
        /// </summary>
        public ResponsesBadRequestResponseErrorData()
        {
        }

    }
}