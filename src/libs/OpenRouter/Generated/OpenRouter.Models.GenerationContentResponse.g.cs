
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stored prompt and completion content for a generation
    /// </summary>
    public sealed partial class GenerationContentResponse
    {
        /// <summary>
        /// Stored prompt and completion content
        /// </summary>
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
        /// Stored prompt and completion content
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