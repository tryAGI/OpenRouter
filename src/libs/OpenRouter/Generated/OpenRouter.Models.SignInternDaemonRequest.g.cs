
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignInternDaemonRequest
    {
        /// <summary>
        /// Lower-case hex SHA-256 of the exact bytes the CLI will send as the daemon request body.<br/>
        /// Example: e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855
        /// </summary>
        /// <example>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bodySha256")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BodySha256 { get; set; }

        /// <summary>
        /// The daemon request the proof is for. When present the response also carries the single-use, route-bound proof (`x-ori-invoke-signature-v2`, `x-ori-invoke-nonce`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public global::OpenRouter.SignInternDaemonRequestRoute? Route { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignInternDaemonRequest" /> class.
        /// </summary>
        /// <param name="bodySha256">
        /// Lower-case hex SHA-256 of the exact bytes the CLI will send as the daemon request body.<br/>
        /// Example: e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855
        /// </param>
        /// <param name="route">
        /// The daemon request the proof is for. When present the response also carries the single-use, route-bound proof (`x-ori-invoke-signature-v2`, `x-ori-invoke-nonce`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignInternDaemonRequest(
            string bodySha256,
            global::OpenRouter.SignInternDaemonRequestRoute? route)
        {
            this.BodySha256 = bodySha256 ?? throw new global::System.ArgumentNullException(nameof(bodySha256));
            this.Route = route;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignInternDaemonRequest" /> class.
        /// </summary>
        public SignInternDaemonRequest()
        {
        }

    }
}