
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// JSON schema constrained response format
    /// </summary>
    public sealed partial class FormatJsonSchemaConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FormatJsonSchemaConfigTypeJsonConverter))]
        public global::OpenRouter.FormatJsonSchemaConfigType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

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
        /// Initializes a new instance of the <see cref="FormatJsonSchemaConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="strict"></param>
        /// <param name="schema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormatJsonSchemaConfig(
            string name,
            object schema,
            global::OpenRouter.FormatJsonSchemaConfigType type,
            string? description,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Type = type;
            this.Description = description;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatJsonSchemaConfig" /> class.
        /// </summary>
        public FormatJsonSchemaConfig()
        {
        }
    }
}