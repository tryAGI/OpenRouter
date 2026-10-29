
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableCustomOrigin
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path_prefix")]
        public string? PathPrefix { get; set; }

        /// <summary>
        /// The vault injection decision for this destination, at `read_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultRoutingTableCustomOriginStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableCustomOrigin" /> class.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="status">
        /// The vault injection decision for this destination, at `read_at`.
        /// </param>
        /// <param name="pathPrefix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableCustomOrigin(
            string host,
            global::OpenRouter.VaultRoutingTableCustomOriginStatus status,
            string? pathPrefix)
        {
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.PathPrefix = pathPrefix;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableCustomOrigin" /> class.
        /// </summary>
        public VaultRoutingTableCustomOrigin()
        {
        }

    }
}