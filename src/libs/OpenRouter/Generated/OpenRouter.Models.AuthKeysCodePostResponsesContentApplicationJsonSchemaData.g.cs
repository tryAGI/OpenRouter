
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Auth code data
    /// </summary>
    public sealed partial class AuthKeysCodePostResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// The application ID associated with this auth code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AppId { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the auth code was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The authorization code ID to use in the exchange request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthKeysCodePostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="appId">
        /// The application ID associated with this auth code
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the auth code was created
        /// </param>
        /// <param name="id">
        /// The authorization code ID to use in the exchange request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthKeysCodePostResponsesContentApplicationJsonSchemaData(
            int appId,
            string createdAt,
            string id)
        {
            this.AppId = appId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthKeysCodePostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public AuthKeysCodePostResponsesContentApplicationJsonSchemaData()
        {
        }
    }
}