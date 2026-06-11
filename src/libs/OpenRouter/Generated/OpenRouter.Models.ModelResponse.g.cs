
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Single model response
    /// </summary>
    public sealed partial class ModelResponse
    {
        /// <summary>
        /// Information about an AI model available on OpenRouter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.Model Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Information about an AI model available on OpenRouter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelResponse(
            global::OpenRouter.Model data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponse" /> class.
        /// </summary>
        public ModelResponse()
        {
        }

    }
}