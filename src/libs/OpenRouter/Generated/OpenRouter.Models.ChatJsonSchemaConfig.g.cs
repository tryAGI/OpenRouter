
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// JSON Schema configuration object<br/>
    /// Example: {"description":"A mathematical response","name":"math_response","schema":{"properties":{"answer":{"type":"number"}},"required":["answer"],"type":"object"},"strict":true}
    /// </summary>
    public sealed partial class ChatJsonSchemaConfig
    {
        /// <summary>
        /// Schema description for the model<br/>
        /// Example: A mathematical response
        /// </summary>
        /// <example>A mathematical response</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Schema name (a-z, A-Z, 0-9, underscores, dashes, max 64 chars)<br/>
        /// Example: math_response
        /// </summary>
        /// <example>math_response</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// JSON Schema object<br/>
        /// Example: {"properties":{"answer":{"type":"number"}},"required":["answer"],"type":"object"}
        /// </summary>
        /// <example>{"properties":{"answer":{"type":"number"}},"required":["answer"],"type":"object"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Enable strict schema adherence<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatJsonSchemaConfig" /> class.
        /// </summary>
        /// <param name="name">
        /// Schema name (a-z, A-Z, 0-9, underscores, dashes, max 64 chars)<br/>
        /// Example: math_response
        /// </param>
        /// <param name="description">
        /// Schema description for the model<br/>
        /// Example: A mathematical response
        /// </param>
        /// <param name="schema">
        /// JSON Schema object<br/>
        /// Example: {"properties":{"answer":{"type":"number"}},"required":["answer"],"type":"object"}
        /// </param>
        /// <param name="strict">
        /// Enable strict schema adherence<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatJsonSchemaConfig(
            string name,
            string? description,
            object? schema,
            bool? strict)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schema = schema;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatJsonSchemaConfig" /> class.
        /// </summary>
        public ChatJsonSchemaConfig()
        {
        }

    }
}