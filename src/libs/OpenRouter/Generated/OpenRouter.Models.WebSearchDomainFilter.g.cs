
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"allowed_domains":["example.com"],"blocked_domains":["spam.com"],"excluded_domains":["spam.com"]}
    /// </summary>
    public sealed partial class WebSearchDomainFilter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchDomainFilter" /> class.
        /// </summary>
        /// <param name="allowedDomains"></param>
        /// <param name="blockedDomains"></param>
        /// <param name="excludedDomains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchDomainFilter(
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            global::System.Collections.Generic.IList<string>? excludedDomains)
        {
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.ExcludedDomains = excludedDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchDomainFilter" /> class.
        /// </summary>
        public WebSearchDomainFilter()
        {
        }

    }
}