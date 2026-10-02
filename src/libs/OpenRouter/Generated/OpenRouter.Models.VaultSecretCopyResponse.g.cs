
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Metadata for the copies now stored in the intern scope, one entry per requested name.<br/>
    /// Example: {"data":[{"created_at":"2026-09-15T17:44:00.000Z","fingerprint":"sha256:9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08","hosts":["api.github.com"],"name":"github_token"}]}
    /// </summary>
    public sealed partial class VaultSecretCopyResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultSecret> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecretCopyResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultSecretCopyResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.VaultSecret> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecretCopyResponse" /> class.
        /// </summary>
        public VaultSecretCopyResponse()
        {
        }

    }
}