
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetObservabilityDestinationResponse
    {
        /// <summary>
        /// The observability destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GetObservabilityDestinationResponseDataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GetObservabilityDestinationResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObservabilityDestinationResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The observability destination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetObservabilityDestinationResponse(
            global::OpenRouter.GetObservabilityDestinationResponseData data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObservabilityDestinationResponse" /> class.
        /// </summary>
        public GetObservabilityDestinationResponse()
        {
        }

    }
}