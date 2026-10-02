
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Debug options for inspecting request transformations (streaming only)<br/>
    /// Example: {"echo_upstream_body":true}
    /// </summary>
    public sealed partial class ChatDebugOptions
    {
        /// <summary>
        /// If true, includes the transformed upstream request body in a debug chunk at the start of the stream. Only works with streaming mode.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("echo_upstream_body")]
        public bool? EchoUpstreamBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDebugOptions" /> class.
        /// </summary>
        /// <param name="echoUpstreamBody">
        /// If true, includes the transformed upstream request body in a debug chunk at the start of the stream. Only works with streaming mode.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatDebugOptions(
            bool? echoUpstreamBody)
        {
            this.EchoUpstreamBody = echoUpstreamBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDebugOptions" /> class.
        /// </summary>
        public ChatDebugOptions()
        {
        }

    }
}