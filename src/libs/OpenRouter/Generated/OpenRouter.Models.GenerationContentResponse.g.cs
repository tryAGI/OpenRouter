
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stored prompt and completion content for a generation<br/>
    /// Example: {"data":{"error":null,"input":{"messages":[{"content":"What is the meaning of life?","role":"user"}]},"output":{"completion":"The meaning of life is a philosophical question...","reasoning":null}}}
    /// </summary>
    public sealed partial class GenerationContentResponse
    {
        /// <summary>
        /// Stored prompt and completion content, plus the failure error when one was stored<br/>
        /// Example: {"error":null,"input":{"messages":[{"content":"What is the meaning of life?","role":"user"}]},"output":{"completion":"The meaning of life is a philosophical question...","reasoning":null}}
        /// </summary>
        /// <example>{"error":null,"input":{"messages":[{"content":"What is the meaning of life?","role":"user"}]},"output":{"completion":"The meaning of life is a philosophical question...","reasoning":null}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GenerationContentData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Stored prompt and completion content, plus the failure error when one was stored<br/>
        /// Example: {"error":null,"input":{"messages":[{"content":"What is the meaning of life?","role":"user"}]},"output":{"completion":"The meaning of life is a philosophical question...","reasoning":null}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationContentResponse(
            global::OpenRouter.GenerationContentData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentResponse" /> class.
        /// </summary>
        public GenerationContentResponse()
        {
        }

    }
}