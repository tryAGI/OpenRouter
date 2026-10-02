
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Function call details
    /// </summary>
    public sealed partial class ChatStreamToolCallFunction
    {
        /// <summary>
        /// Function arguments as JSON string<br/>
        /// Example: {"location": "..."}
        /// </summary>
        /// <example>{"location": "..."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Function name<br/>
        /// Example: get_weather
        /// </summary>
        /// <example>get_weather</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamToolCallFunction" /> class.
        /// </summary>
        /// <param name="arguments">
        /// Function arguments as JSON string<br/>
        /// Example: {"location": "..."}
        /// </param>
        /// <param name="name">
        /// Function name<br/>
        /// Example: get_weather
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamToolCallFunction(
            string? arguments,
            string? name)
        {
            this.Arguments = arguments;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamToolCallFunction" /> class.
        /// </summary>
        public ChatStreamToolCallFunction()
        {
        }

    }
}