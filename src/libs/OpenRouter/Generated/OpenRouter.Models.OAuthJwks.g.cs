
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// RFC 7517 JWK Set of the keys OpenRouter signs access tokens with.<br/>
    /// Example: {"keys":[{"alg":"ES256","crv":"P-256","kid":"or-2026-09","kty":"EC","use":"sig","x":"f83OJ3D2xF1Bg8vub9tLe1gHMzV76e8Tus9uPHvRVEU","y":"x_FEzRu9m36HLN_tue659LNpXW6pCyStikYjKIWI5a0"}]}
    /// </summary>
    public sealed partial class OAuthJwks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OAuthJwksKey> Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthJwks" /> class.
        /// </summary>
        /// <param name="keys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthJwks(
            global::System.Collections.Generic.IList<global::OpenRouter.OAuthJwksKey> keys)
        {
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthJwks" /> class.
        /// </summary>
        public OAuthJwks()
        {
        }

    }
}