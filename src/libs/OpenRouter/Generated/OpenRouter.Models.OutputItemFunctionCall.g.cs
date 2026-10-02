
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"arguments":"{\u0022location\u0022:\u0022San Francisco\u0022,\u0022unit\u0022:\u0022celsius\u0022}","call_id":"call-abc123","id":"call-abc123","name":"get_weather","type":"function_call"}
    /// </summary>
    public sealed partial class OutputItemFunctionCall
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// True when the model called a tool declared with `async: true` and may continue its turn before the output is returned. Return the result in a later request as a `function_call_output` with this `call_id`.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Namespace qualifier for tools registered as part of a namespace tool group (e.g. an MCP server)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.OutputItemFunctionCallStatusVariant1?, global::OpenRouter.OutputItemFunctionCallStatusVariant2?, global::OpenRouter.OutputItemFunctionCallStatusVariant3?>))]
        public global::OpenRouter.AnyOf<global::OpenRouter.OutputItemFunctionCallStatusVariant1?, global::OpenRouter.OutputItemFunctionCallStatusVariant2?, global::OpenRouter.OutputItemFunctionCallStatusVariant3?>? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemFunctionCallTypeJsonConverter))]
        public global::OpenRouter.OutputItemFunctionCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemFunctionCall" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="callId"></param>
        /// <param name="name"></param>
        /// <param name="async">
        /// True when the model called a tool declared with `async: true` and may continue its turn before the output is returned. Return the result in a later request as a `function_call_output` with this `call_id`.<br/>
        /// Example: true
        /// </param>
        /// <param name="id"></param>
        /// <param name="namespace">
        /// Namespace qualifier for tools registered as part of a namespace tool group (e.g. an MCP server)
        /// </param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemFunctionCall(
            string arguments,
            string callId,
            string name,
            bool? async,
            string? id,
            string? @namespace,
            global::OpenRouter.AnyOf<global::OpenRouter.OutputItemFunctionCallStatusVariant1?, global::OpenRouter.OutputItemFunctionCallStatusVariant2?, global::OpenRouter.OutputItemFunctionCallStatusVariant3?>? status,
            global::OpenRouter.OutputItemFunctionCallType type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Async = async;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Namespace = @namespace;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemFunctionCall" /> class.
        /// </summary>
        public OutputItemFunctionCall()
        {
        }

    }
}