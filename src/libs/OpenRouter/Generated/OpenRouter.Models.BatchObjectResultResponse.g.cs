
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.BatchObjectResultResponseBodyVariant1, global::OpenRouter.OpenResponsesResult?, global::OpenRouter.BatchObjectResultResponseBodyVariant3, global::OpenRouter.BatchObjectResultResponseBodyVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::OpenRouter.BatchObjectResultResponseBodyVariant1, global::OpenRouter.OpenResponsesResult?, global::OpenRouter.BatchObjectResultResponseBodyVariant3, global::OpenRouter.BatchObjectResultResponseBodyVariant4> Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponse" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="statusCode"></param>
        /// <param name="requestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponse(
            global::OpenRouter.AnyOf<global::OpenRouter.BatchObjectResultResponseBodyVariant1, global::OpenRouter.OpenResponsesResult?, global::OpenRouter.BatchObjectResultResponseBodyVariant3, global::OpenRouter.BatchObjectResultResponseBodyVariant4> body,
            int statusCode,
            string? requestId)
        {
            this.Body = body;
            this.RequestId = requestId;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponse" /> class.
        /// </summary>
        public BatchObjectResultResponse()
        {
        }

    }
}