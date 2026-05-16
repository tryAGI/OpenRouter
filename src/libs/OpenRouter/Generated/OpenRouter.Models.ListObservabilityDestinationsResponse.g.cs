
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
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
        /// Total number of destinations matching the filters.
        /// </summary>
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
        /// Total number of destinations matching the filters.
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