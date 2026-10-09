
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Headers the CLI copies onto the daemon request so the sidecar can verify who is asking.<br/>
    /// Example: {"x-ori-invoke-signature":"MEUCIQ...","x-ori-invoke-timestamp":"1789000000","x-ori-invoke-user":"user_2abc"}
    /// </summary>
    public sealed partial class SignInternDaemonResponse
    {
        /// <summary>
        /// Base64 Ed25519 signature over the intern id, timestamp, user and body digest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x-ori-invoke-signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XOriInvokeSignature { get; set; }

        /// <summary>
        /// Unix seconds at signing; the daemon refuses proofs older than its window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x-ori-invoke-timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XOriInvokeTimestamp { get; set; }

        /// <summary>
        /// The verified OAuth subject the proof names. Never taken from the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x-ori-invoke-user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XOriInvokeUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignInternDaemonResponse" /> class.
        /// </summary>
        /// <param name="xOriInvokeSignature">
        /// Base64 Ed25519 signature over the intern id, timestamp, user and body digest.
        /// </param>
        /// <param name="xOriInvokeTimestamp">
        /// Unix seconds at signing; the daemon refuses proofs older than its window.
        /// </param>
        /// <param name="xOriInvokeUser">
        /// The verified OAuth subject the proof names. Never taken from the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignInternDaemonResponse(
            string xOriInvokeSignature,
            string xOriInvokeTimestamp,
            string xOriInvokeUser)
        {
            this.XOriInvokeSignature = xOriInvokeSignature ?? throw new global::System.ArgumentNullException(nameof(xOriInvokeSignature));
            this.XOriInvokeTimestamp = xOriInvokeTimestamp ?? throw new global::System.ArgumentNullException(nameof(xOriInvokeTimestamp));
            this.XOriInvokeUser = xOriInvokeUser ?? throw new global::System.ArgumentNullException(nameof(xOriInvokeUser));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignInternDaemonResponse" /> class.
        /// </summary>
        public SignInternDaemonResponse()
        {
        }

    }
}