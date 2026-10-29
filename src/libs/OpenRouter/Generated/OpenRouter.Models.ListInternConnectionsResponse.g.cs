
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListInternConnectionsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ListInternConnectionsResponseDataItem> Data { get; set; }

        /// <summary>
        /// The intern's routing table, for the intern's own key only; null for any other caller or when the vault could not build it in time. The keys still list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing")]
        public global::OpenRouter.VaultRoutingTable? Routing { get; set; }

        /// <summary>
        /// The routing table as the plain lines the intern reads in its instructions' Connections section, or a notice that it could not be read; null for a caller other than the intern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_text")]
        public string? RoutingText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInternConnectionsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="routing">
        /// The intern's routing table, for the intern's own key only; null for any other caller or when the vault could not build it in time. The keys still list.
        /// </param>
        /// <param name="routingText">
        /// The routing table as the plain lines the intern reads in its instructions' Connections section, or a notice that it could not be read; null for a caller other than the intern.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListInternConnectionsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.ListInternConnectionsResponseDataItem> data,
            global::OpenRouter.VaultRoutingTable? routing,
            string? routingText)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Routing = routing;
            this.RoutingText = routingText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInternConnectionsResponse" /> class.
        /// </summary>
        public ListInternConnectionsResponse()
        {
        }

    }
}