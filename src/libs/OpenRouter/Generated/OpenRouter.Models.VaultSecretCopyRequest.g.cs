
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Workspace secrets to copy into the intern scope.<br/>
    /// Example: {"names":["github_token"]}
    /// </summary>
    public sealed partial class VaultSecretCopyRequest
    {
        /// <summary>
        /// Names of workspace secrets to copy, 1 to 100 unique entries. Every name must exist in the workspace scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecretCopyRequest" /> class.
        /// </summary>
        /// <param name="names">
        /// Names of workspace secrets to copy, 1 to 100 unique entries. Every name must exist in the workspace scope.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultSecretCopyRequest(
            global::System.Collections.Generic.IList<string> names)
        {
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecretCopyRequest" /> class.
        /// </summary>
        public VaultSecretCopyRequest()
        {
        }

    }
}