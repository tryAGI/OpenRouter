
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The vault injection decision for this destination, at `read_at`.
    /// </summary>
    public sealed partial class VaultRoutingTableCustomOriginStatus
    {
        /// <summary>
        /// The credential failure code when `state` is `failing`; null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        public string? Failure { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VaultRoutingTableCustomOriginStatusStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultRoutingTableCustomOriginStatusState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableCustomOriginStatus" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="failure">
        /// The credential failure code when `state` is `failing`; null otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableCustomOriginStatus(
            global::OpenRouter.VaultRoutingTableCustomOriginStatusState state,
            string? failure)
        {
            this.Failure = failure;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableCustomOriginStatus" /> class.
        /// </summary>
        public VaultRoutingTableCustomOriginStatus()
        {
        }

    }
}