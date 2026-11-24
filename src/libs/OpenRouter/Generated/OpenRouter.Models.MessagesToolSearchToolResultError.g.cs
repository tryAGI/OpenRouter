
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A tool search that returned an error in place of tools.<br/>
    /// Example: {"error_code":"unavailable","error_message":null,"type":"tool_search_tool_result_error"}
    /// </summary>
    public sealed partial class MessagesToolSearchToolResultError
    {
        /// <summary>
        /// Why a tool search returned no result.<br/>
        /// Example: unavailable
        /// </summary>
        /// <example>unavailable</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesToolSearchToolResultErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesToolSearchToolResultErrorCode ErrorCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesToolSearchToolResultErrorTypeJsonConverter))]
        public global::OpenRouter.MessagesToolSearchToolResultErrorType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolSearchToolResultError" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// Why a tool search returned no result.<br/>
        /// Example: unavailable
        /// </param>
        /// <param name="errorMessage"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesToolSearchToolResultError(
            global::OpenRouter.MessagesToolSearchToolResultErrorCode errorCode,
            string? errorMessage,
            global::OpenRouter.MessagesToolSearchToolResultErrorType type)
        {
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolSearchToolResultError" /> class.
        /// </summary>
        public MessagesToolSearchToolResultError()
        {
        }

    }
}