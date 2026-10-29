
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableMcpOriginRoute
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableMcpOriginRoute" /> class.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="pathPrefix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableMcpOriginRoute(
            string host,
            string? pathPrefix)
        {
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.PathPrefix = pathPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableMcpOriginRoute" /> class.
        /// </summary>
        public VaultRoutingTableMcpOriginRoute()
        {
        }

    }
}