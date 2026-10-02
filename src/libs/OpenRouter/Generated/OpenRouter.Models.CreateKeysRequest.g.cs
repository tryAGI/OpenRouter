
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"expires_at":"2027-12-31T23:59:59Z","include_byok_in_limit":true,"limit":50,"limit_reset":"monthly","name":"My New API Key"}
    /// </summary>
    public sealed partial class CreateKeysRequest
    {
        /// <summary>
        /// Optional user ID of the key creator. Only meaningful for organization-owned keys where a specific member is creating the key.<br/>
        /// Example: user_2dHFtVWx2n56w6HkM0000000000
        /// </summary>
        /// <example>user_2dHFtVWx2n56w6HkM0000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_user_id")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// Optional ISO 8601 UTC expiration timestamp. Must include seconds (YYYY-MM-DDTHH:MM:SSZ; fractional seconds allowed); minute-precision timestamps are rejected.<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </summary>
        /// <example>2027-12-31T23:59:59Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Optional partner-defined identity associated with the created API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external")]
        public global::OpenRouter.CreateKeysRequestExternal? External { get; set; }

        /// <summary>
        /// Whether to include BYOK usage in the limit<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_limit")]
        public bool? IncludeByokInLimit { get; set; }

        /// <summary>
        /// Optional spending limit for the API key in USD<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.<br/>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_reset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateKeysRequestLimitResetJsonConverter))]
        public global::OpenRouter.CreateKeysRequestLimitReset? LimitReset { get; set; }

        /// <summary>
        /// Name for the new API key<br/>
        /// Example: My New API Key
        /// </summary>
        /// <example>My New API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The workspace to create the API key in. Defaults to the default workspace if not provided.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </summary>
        /// <example>0df9e665-d932-5740-b2c7-b52af166bc11</example>
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
        /// Name for the new API key<br/>
        /// Example: My New API Key
        /// </param>
        /// <param name="creatorUserId">
        /// Optional user ID of the key creator. Only meaningful for organization-owned keys where a specific member is creating the key.<br/>
        /// Example: user_2dHFtVWx2n56w6HkM0000000000
        /// </param>
        /// <param name="expiresAt">
        /// Optional ISO 8601 UTC expiration timestamp. Must include seconds (YYYY-MM-DDTHH:MM:SSZ; fractional seconds allowed); minute-precision timestamps are rejected.<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </param>
        /// <param name="external">
        /// Optional partner-defined identity associated with the created API key.
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit<br/>
        /// Example: true
        /// </param>
        /// <param name="limit">
        /// Optional spending limit for the API key in USD<br/>
        /// Example: 50
        /// </param>
        /// <param name="limitReset">
        /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="workspaceId">
        /// The workspace to create the API key in. Defaults to the default workspace if not provided.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKeysRequest(
            string name,
            string? creatorUserId,
            global::System.DateTime? expiresAt,
            global::OpenRouter.CreateKeysRequestExternal? external,
            bool? includeByokInLimit,
            double? limit,
            global::OpenRouter.CreateKeysRequestLimitReset? limitReset,
            global::System.Guid? workspaceId)
        {
            this.CreatorUserId = creatorUserId;
            this.ExpiresAt = expiresAt;
            this.External = external;
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