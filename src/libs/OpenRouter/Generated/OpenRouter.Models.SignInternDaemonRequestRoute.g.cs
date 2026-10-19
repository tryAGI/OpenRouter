
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The daemon request the proof is for. When present the response also carries the single-use, route-bound proof (`x-ori-invoke-signature-v2`, `x-ori-invoke-nonce`).
    /// </summary>
    public sealed partial class SignInternDaemonRequestRoute
    {
        /// <summary>
        /// The HTTP method of the daemon request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SignInternDaemonRequestRouteMethodJsonConverter))]
        public global::OpenRouter.SignInternDaemonRequestRouteMethod Method { get; set; }

        /// <summary>
        /// The daemon request path, percent-encoded as sent, without origin or query. The route-bound proof admits only this path.<br/>
        /// Example: /api/invoke
        /// </summary>
        /// <example>/api/invoke</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignInternDaemonRequestRoute" /> class.
        /// </summary>
        /// <param name="path">
        /// The daemon request path, percent-encoded as sent, without origin or query. The route-bound proof admits only this path.<br/>
        /// Example: /api/invoke
        /// </param>
        /// <param name="method">
        /// The HTTP method of the daemon request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignInternDaemonRequestRoute(
            string path,
            global::OpenRouter.SignInternDaemonRequestRouteMethod method)
        {
            this.Method = method;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignInternDaemonRequestRoute" /> class.
        /// </summary>
        public SignInternDaemonRequestRoute()
        {
        }

    }
}