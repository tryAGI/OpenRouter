
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContainerNetworkPolicyVariant2
    {
        /// <summary>
        /// Hostnames the container may reach over ports 80/443 (max 50). Entries are lowercase hostnames or glob patterns where * matches any run of characters (e.g. *.example.com). An exact hostname does not cover its subdomains — use a glob or list each hostname. pip needs both pypi.org and files.pythonhosted.org (or *.pythonhosted.org).<br/>
        /// Example: [pypi.org, files.pythonhosted.org]
        /// </summary>
        /// <example>[pypi.org, files.pythonhosted.org]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedDomains { get; set; }

        /// <summary>
        /// Outbound access restricted to the listed domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContainerNetworkPolicyVariant2TypeJsonConverter))]
        public global::OpenRouter.ContainerNetworkPolicyVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerNetworkPolicyVariant2" /> class.
        /// </summary>
        /// <param name="allowedDomains">
        /// Hostnames the container may reach over ports 80/443 (max 50). Entries are lowercase hostnames or glob patterns where * matches any run of characters (e.g. *.example.com). An exact hostname does not cover its subdomains — use a glob or list each hostname. pip needs both pypi.org and files.pythonhosted.org (or *.pythonhosted.org).<br/>
        /// Example: [pypi.org, files.pythonhosted.org]
        /// </param>
        /// <param name="type">
        /// Outbound access restricted to the listed domains.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerNetworkPolicyVariant2(
            global::System.Collections.Generic.IList<string> allowedDomains,
            global::OpenRouter.ContainerNetworkPolicyVariant2Type type)
        {
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerNetworkPolicyVariant2" /> class.
        /// </summary>
        public ContainerNetworkPolicyVariant2()
        {
        }

    }
}