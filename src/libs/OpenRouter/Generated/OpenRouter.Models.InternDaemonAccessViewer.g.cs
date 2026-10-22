
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InternDaemonAccessViewer
    {
        /// <summary>
        /// The caller's Ori principals on this intern: `clerk:&lt;user&gt;`, and, when the grant carries `vault:read`, `slack:&lt;team&gt;:&lt;user&gt;` for each Slack account they linked to it. A session started by one of them in a one-to-one Slack DM is the caller's to see.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Principals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternDaemonAccessViewer" /> class.
        /// </summary>
        /// <param name="principals">
        /// The caller's Ori principals on this intern: `clerk:&lt;user&gt;`, and, when the grant carries `vault:read`, `slack:&lt;team&gt;:&lt;user&gt;` for each Slack account they linked to it. A session started by one of them in a one-to-one Slack DM is the caller's to see.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternDaemonAccessViewer(
            global::System.Collections.Generic.IList<string> principals)
        {
            this.Principals = principals ?? throw new global::System.ArgumentNullException(nameof(principals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternDaemonAccessViewer" /> class.
        /// </summary>
        public InternDaemonAccessViewer()
        {
        }

    }
}