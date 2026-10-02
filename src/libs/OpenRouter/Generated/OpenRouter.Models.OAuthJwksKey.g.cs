
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OAuthJwksKey
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alg")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OAuthJwksKeyAlgJsonConverter))]
        public global::OpenRouter.OAuthJwksKeyAlg Alg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crv")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OAuthJwksKeyCrvJsonConverter))]
        public global::OpenRouter.OAuthJwksKeyCrv Crv { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kty")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OAuthJwksKeyKtyJsonConverter))]
        public global::OpenRouter.OAuthJwksKeyKty Kty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OAuthJwksKeyUseJsonConverter))]
        public global::OpenRouter.OAuthJwksKeyUse Use { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string X { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthJwksKey" /> class.
        /// </summary>
        /// <param name="kid"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="alg"></param>
        /// <param name="crv"></param>
        /// <param name="kty"></param>
        /// <param name="use"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthJwksKey(
            string kid,
            string x,
            string y,
            global::OpenRouter.OAuthJwksKeyAlg alg,
            global::OpenRouter.OAuthJwksKeyCrv crv,
            global::OpenRouter.OAuthJwksKeyKty kty,
            global::OpenRouter.OAuthJwksKeyUse use)
        {
            this.Alg = alg;
            this.Crv = crv;
            this.Kid = kid ?? throw new global::System.ArgumentNullException(nameof(kid));
            this.Kty = kty;
            this.Use = use;
            this.X = x ?? throw new global::System.ArgumentNullException(nameof(x));
            this.Y = y ?? throw new global::System.ArgumentNullException(nameof(y));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthJwksKey" /> class.
        /// </summary>
        public OAuthJwksKey()
        {
        }

    }
}