
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when an error occurs during streaming<br/>
    /// Example: {"code":"rate_limit_exceeded","message":"Rate limit exceeded. Please try again later.","param":null,"sequence_number":2,"type":"error"}
    /// </summary>
    public sealed partial class BaseErrorEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseErrorEventTypeJsonConverter))]
        public global::OpenRouter.BaseErrorEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseErrorEvent" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="code"></param>
        /// <param name="param"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseErrorEvent(
            string message,
            int sequenceNumber,
            string? code,
            string? param,
            global::OpenRouter.BaseErrorEventType type)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseErrorEvent" /> class.
        /// </summary>
        public BaseErrorEvent()
        {
        }

    }
}