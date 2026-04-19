
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKeysRequest
    {
        /// <summary>
        /// Optional user ID of the key creator. Only meaningful for organization-owned keys where a specific member is creating the key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_user_id")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// Optional ISO 8601 UTC timestamp when the API key should expire. Must be UTC, other timezones will be rejected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Whether to include BYOK usage in the limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_limit")]
        public bool? IncludeByokInLimit { get; set; }

        /// <summary>
        /// Optional spending limit for the API key in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_reset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>? LimitReset { get; set; }

        /// <summary>
        /// Name for the new API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The workspace to create the API key in. Defaults to the default workspace if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeysRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new API key
        /// </param>
        /// <param name="creatorUserId">
        /// Optional user ID of the key creator. Only meaningful for organization-owned keys where a specific member is creating the key.
        /// </param>
        /// <param name="expiresAt">
        /// Optional ISO 8601 UTC timestamp when the API key should expire. Must be UTC, other timezones will be rejected
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit
        /// </param>
        /// <param name="limit">
        /// Optional spending limit for the API key in USD
        /// </param>
        /// <param name="limitReset">
        /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </param>
        /// <param name="workspaceId">
        /// The workspace to create the API key in. Defaults to the default workspace if not provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKeysRequest(
            string name,
            string? creatorUserId,
            global::System.DateTime? expiresAt,
            bool? includeByokInLimit,
            double? limit,
            global::OpenRouter.OneOf<global::OpenRouter.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>? limitReset,
            global::System.Guid? workspaceId)
        {
            this.CreatorUserId = creatorUserId;
            this.ExpiresAt = expiresAt;
            this.IncludeByokInLimit = includeByokInLimit;
            this.Limit = limit;
            this.LimitReset = limitReset;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeysRequest" /> class.
        /// </summary>
        public CreateKeysRequest()
        {
        }
    }
}