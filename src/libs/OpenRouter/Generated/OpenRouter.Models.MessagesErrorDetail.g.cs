
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesErrorDetail
    {
        /// <summary>
        /// Canonical OpenRouter error type, stable across all API formats
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApiErrorTypeJsonConverter))]
        public global::OpenRouter.ApiErrorType? ErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesErrorDetail" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="errorType">
        /// Canonical OpenRouter error type, stable across all API formats
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesErrorDetail(
            string message,
            string type,
            global::OpenRouter.ApiErrorType? errorType)
        {
            this.ErrorType = errorType;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesErrorDetail" /> class.
        /// </summary>
        public MessagesErrorDetail()
        {
        }

    }
}