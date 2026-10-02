
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServerToolOutputName
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ServerToolOutputNameApiFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ServerToolOutputNameApiFormat ApiFormat { get; set; }

        /// <summary>
        /// Anthropic Messages `server_tool_use` block `name`, when the call surfaces as one<br/>
        /// Example: web_search
        /// </summary>
        /// <example>web_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Output item `type` on Responses, content block `type` on Anthropic Messages, `reasoning_details[].type` on Chat Completions<br/>
        /// Example: web_search_call
        /// </summary>
        /// <example>web_search_call</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolOutputName" /> class.
        /// </summary>
        /// <param name="apiFormat"></param>
        /// <param name="type">
        /// Output item `type` on Responses, content block `type` on Anthropic Messages, `reasoning_details[].type` on Chat Completions<br/>
        /// Example: web_search_call
        /// </param>
        /// <param name="name">
        /// Anthropic Messages `server_tool_use` block `name`, when the call surfaces as one<br/>
        /// Example: web_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerToolOutputName(
            global::OpenRouter.ServerToolOutputNameApiFormat apiFormat,
            string type,
            string? name)
        {
            this.ApiFormat = apiFormat;
            this.Name = name;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolOutputName" /> class.
        /// </summary>
        public ServerToolOutputName()
        {
        }

    }
}