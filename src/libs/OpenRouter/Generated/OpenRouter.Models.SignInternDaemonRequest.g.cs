
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignInternDaemonRequest(
            string bodySha256)
        {
            this.BodySha256 = bodySha256 ?? throw new global::System.ArgumentNullException(nameof(bodySha256));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignInternDaemonRequest" /> class.
        /// </summary>
        public SignInternDaemonRequest()
        {
        }

    }
}