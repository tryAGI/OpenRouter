
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A schema to specify Claude's output format in responses. See [structured outputs](https://platform.claude.com/docs/en/build-with-claude/structured-outputs).
    /// </summary>
    public sealed partial class MessagesOutputConfigFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigFormatTypeJsonConverter))]
        public global::OpenRouter.MessagesOutputConfigFormatType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfigFormat" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="schema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesOutputConfigFormat(
            object schema,
            global::OpenRouter.MessagesOutputConfigFormatType type)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfigFormat" /> class.
        /// </summary>
        public MessagesOutputConfigFormat()
        {
        }
    }
}