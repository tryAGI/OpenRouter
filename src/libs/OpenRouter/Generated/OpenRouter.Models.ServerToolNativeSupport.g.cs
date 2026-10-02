
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Endpoints whose provider runs this tool itself during inference. Zero for tools no provider runs natively.<br/>
    /// Example: {"endpoint_count":18,"model_count":12}
    /// </summary>
    public sealed partial class ServerToolNativeSupport
    {
        /// <summary>
        /// Example: 18
        /// </summary>
        /// <example>18</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndpointCount { get; set; }

        /// <summary>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModelCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolNativeSupport" /> class.
        /// </summary>
        /// <param name="endpointCount">
        /// Example: 18
        /// </param>
        /// <param name="modelCount">
        /// Example: 12
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerToolNativeSupport(
            int endpointCount,
            int modelCount)
        {
            this.EndpointCount = endpointCount;
            this.ModelCount = modelCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolNativeSupport" /> class.
        /// </summary>
        public ServerToolNativeSupport()
        {
        }

    }
}