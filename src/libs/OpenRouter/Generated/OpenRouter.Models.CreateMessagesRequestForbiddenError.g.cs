
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMessagesRequestForbiddenError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesPostResponsesContentApplicationJsonSchemaTypeJsonConverter))]
        public global::OpenRouter.MessagesPostResponsesContentApplicationJsonSchemaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesPostResponsesContentApplicationJsonSchemaError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessagesRequestForbiddenError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMessagesRequestForbiddenError(
            global::OpenRouter.MessagesPostResponsesContentApplicationJsonSchemaError error,
            global::OpenRouter.MessagesPostResponsesContentApplicationJsonSchemaType type)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessagesRequestForbiddenError" /> class.
        /// </summary>
        public CreateMessagesRequestForbiddenError()
        {
        }
    }
}