
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The intern daemon's origin, the bearer `ori tui --host` sends to it as `ORI_DAEMON_TOKEN`, and who the caller is on the intern.<br/>
    /// Example: {"origin":"https://research-assistant-7c9e6679.or.bot","token":"daemon_token","viewer":{"principals":["clerk:user_2abc","slack:T0123:U0456"]}}
    /// </summary>
    public sealed partial class InternDaemonAccess
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternDaemonAccessViewer Viewer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternDaemonAccess" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="token"></param>
        /// <param name="viewer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternDaemonAccess(
            string origin,
            string token,
            global::OpenRouter.InternDaemonAccessViewer viewer)
        {
            this.Origin = origin ?? throw new global::System.ArgumentNullException(nameof(origin));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Viewer = viewer ?? throw new global::System.ArgumentNullException(nameof(viewer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternDaemonAccess" /> class.
        /// </summary>
        public InternDaemonAccess()
        {
        }

    }
}