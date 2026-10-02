
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Error of a failed response; `metadata` carries OpenRouter-specific details.<br/>
    /// Example: {"code":"server_error","message":"Alignment plugin: the reply could not be evaluated: evaluator_error","metadata":{"alignment":{"calls":[{"call":1,"outcome":"unavailable","reason":"evaluator_error"}]}}}
    /// </summary>
    public sealed partial class OpenResponsesErrorField
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenResponsesErrorFieldCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenResponsesErrorFieldCode Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// OpenRouter-specific details of a failed response, such as the alignment object of an alignment error.<br/>
        /// Example: {"alignment":{"calls":[{"call":1,"outcome":"unavailable","reason":"evaluator_error"}]}}
        /// </summary>
        /// <example>{"alignment":{"calls":[{"call":1,"outcome":"unavailable","reason":"evaluator_error"}]}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::OpenRouter.OpenResponsesErrorMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesErrorField" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="metadata">
        /// OpenRouter-specific details of a failed response, such as the alignment object of an alignment error.<br/>
        /// Example: {"alignment":{"calls":[{"call":1,"outcome":"unavailable","reason":"evaluator_error"}]}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenResponsesErrorField(
            global::OpenRouter.OpenResponsesErrorFieldCode code,
            string message,
            global::OpenRouter.OpenResponsesErrorMetadata? metadata)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesErrorField" /> class.
        /// </summary>
        public OpenResponsesErrorField()
        {
        }

    }
}