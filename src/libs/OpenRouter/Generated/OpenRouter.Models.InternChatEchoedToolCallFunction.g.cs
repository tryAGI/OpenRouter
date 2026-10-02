
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The function name and JSON arguments string exactly as streamed.<br/>
    /// Example: {"arguments":"{\u0022kind\u0022:\u0022permission\u0022,\u0022operation\u0022:\u0022shell\u0022,\u0022options\u0022:[\u0022allow_once\u0022,\u0022reject_once\u0022]}","name":"openrouter.provide_input"}
    /// </summary>
    public sealed partial class InternChatEchoedToolCallFunction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatEchoedToolCallFunction" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatEchoedToolCallFunction(
            string arguments,
            string name)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatEchoedToolCallFunction" /> class.
        /// </summary>
        public InternChatEchoedToolCallFunction()
        {
        }

    }
}