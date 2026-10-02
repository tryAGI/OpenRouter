
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Langfuse","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"langfuse","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}],"total_count":1}
    /// </summary>
    public sealed partial class ListObservabilityDestinationsResponse
    {
        /// <summary>
        /// List of observability destinations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDestination> Data { get; set; }

        /// <summary>
        /// Total number of destinations matching the filters.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListObservabilityDestinationsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of observability destinations.
        /// </param>
        /// <param name="totalCount">
        /// Total number of destinations matching the filters.<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListObservabilityDestinationsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDestination> data,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListObservabilityDestinationsResponse" /> class.
        /// </summary>
        public ListObservabilityDestinationsResponse()
        {
        }

    }
}