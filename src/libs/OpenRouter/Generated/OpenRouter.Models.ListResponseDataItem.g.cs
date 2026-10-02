
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"byok_usage":17.38,"byok_usage_daily":17.38,"byok_usage_monthly":17.38,"byok_usage_weekly":17.38,"created_at":"2025-08-24T10:30:00Z","creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","disabled":false,"expires_at":"2027-12-31T23:59:59Z","external_user":null,"hash":"f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943","include_byok_in_limit":false,"label":"sk-or-v1-0e6...1c96","limit":100,"limit_remaining":74.5,"limit_reset":"monthly","name":"My Production Key","updated_at":"2025-08-24T15:45:00Z","usage":25.5,"usage_daily":25.5,"usage_monthly":25.5,"usage_weekly":25.5,"workspace_id":"0df9e665-d932-5740-b2c7-b52af166bc11"}
    /// </summary>
    public sealed partial class ListResponseDataItem
    {
        /// <summary>
        /// Total external BYOK usage (in USD) for the API key<br/>
        /// Example: 17.38F
        /// </summary>
        /// <example>17.38F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ByokUsage { get; set; }

        /// <summary>
        /// External BYOK usage (in USD) for the current UTC day<br/>
        /// Example: 17.38F
        /// </summary>
        /// <example>17.38F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_usage_daily")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ByokUsageDaily { get; set; }

        /// <summary>
        /// External BYOK usage (in USD) for current UTC month<br/>
        /// Example: 17.38F
        /// </summary>
        /// <example>17.38F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_usage_monthly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ByokUsageMonthly { get; set; }

        /// <summary>
        /// External BYOK usage (in USD) for the current UTC week (Monday-Sunday)<br/>
        /// Example: 17.38F
        /// </summary>
        /// <example>17.38F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_usage_weekly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ByokUsageWeekly { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the API key was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </summary>
        /// <example>2025-08-24T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The user ID of the key creator. For organization-owned keys, this is the member who created the key. For individual users, this is the user's own ID.<br/>
        /// Example: user_2dHFtVWx2n56w6HkM0000000000
        /// </summary>
        /// <example>user_2dHFtVWx2n56w6HkM0000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_user_id")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// Whether the API key is disabled<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// ISO 8601 UTC timestamp when the API key expires, or null if no expiration<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </summary>
        /// <example>2027-12-31T23:59:59Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Partner's end-user identifier used for attribution.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user")]
        public string? ExternalUser { get; set; }

        /// <summary>
        /// Unique hash identifier for the API key<br/>
        /// Example: f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943
        /// </summary>
        /// <example>f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        /// Whether to include external BYOK usage in the credit limit<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeByokInLimit { get; set; }

        /// <summary>
        /// Human-readable label for the API key<br/>
        /// Example: sk-or-v1-0e6...1c96
        /// </summary>
        /// <example>sk-or-v1-0e6...1c96</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Spending limit for the API key in USD<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Remaining spending limit in USD<br/>
        /// Example: 74.5F
        /// </summary>
        /// <example>74.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_remaining")]
        public double? LimitRemaining { get; set; }

        /// <summary>
        /// Type of limit reset for the API key<br/>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_reset")]
        public string? LimitReset { get; set; }

        /// <summary>
        /// Name of the API key<br/>
        /// Example: My Production Key
        /// </summary>
        /// <example>My Production Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the API key was last updated<br/>
        /// Example: 2025-08-24T15:45:00Z
        /// </summary>
        /// <example>2025-08-24T15:45:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Total OpenRouter credit usage (in USD) for the API key<br/>
        /// Example: 25.5F
        /// </summary>
        /// <example>25.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Usage { get; set; }

        /// <summary>
        /// OpenRouter credit usage (in USD) for the current UTC day<br/>
        /// Example: 25.5F
        /// </summary>
        /// <example>25.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_daily")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageDaily { get; set; }

        /// <summary>
        /// OpenRouter credit usage (in USD) for the current UTC month<br/>
        /// Example: 25.5F
        /// </summary>
        /// <example>25.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_monthly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageMonthly { get; set; }

        /// <summary>
        /// OpenRouter credit usage (in USD) for the current UTC week (Monday-Sunday)<br/>
        /// Example: 25.5F
        /// </summary>
        /// <example>25.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_weekly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageWeekly { get; set; }

        /// <summary>
        /// The workspace ID this API key belongs to.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </summary>
        /// <example>0df9e665-d932-5740-b2c7-b52af166bc11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseDataItem" /> class.
        /// </summary>
        /// <param name="byokUsage">
        /// Total external BYOK usage (in USD) for the API key<br/>
        /// Example: 17.38F
        /// </param>
        /// <param name="byokUsageDaily">
        /// External BYOK usage (in USD) for the current UTC day<br/>
        /// Example: 17.38F
        /// </param>
        /// <param name="byokUsageMonthly">
        /// External BYOK usage (in USD) for current UTC month<br/>
        /// Example: 17.38F
        /// </param>
        /// <param name="byokUsageWeekly">
        /// External BYOK usage (in USD) for the current UTC week (Monday-Sunday)<br/>
        /// Example: 17.38F
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the API key was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </param>
        /// <param name="disabled">
        /// Whether the API key is disabled<br/>
        /// Example: false
        /// </param>
        /// <param name="hash">
        /// Unique hash identifier for the API key<br/>
        /// Example: f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include external BYOK usage in the credit limit<br/>
        /// Example: false
        /// </param>
        /// <param name="label">
        /// Human-readable label for the API key<br/>
        /// Example: sk-or-v1-0e6...1c96
        /// </param>
        /// <param name="name">
        /// Name of the API key<br/>
        /// Example: My Production Key
        /// </param>
        /// <param name="usage">
        /// Total OpenRouter credit usage (in USD) for the API key<br/>
        /// Example: 25.5F
        /// </param>
        /// <param name="usageDaily">
        /// OpenRouter credit usage (in USD) for the current UTC day<br/>
        /// Example: 25.5F
        /// </param>
        /// <param name="usageMonthly">
        /// OpenRouter credit usage (in USD) for the current UTC month<br/>
        /// Example: 25.5F
        /// </param>
        /// <param name="usageWeekly">
        /// OpenRouter credit usage (in USD) for the current UTC week (Monday-Sunday)<br/>
        /// Example: 25.5F
        /// </param>
        /// <param name="workspaceId">
        /// The workspace ID this API key belongs to.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="creatorUserId">
        /// The user ID of the key creator. For organization-owned keys, this is the member who created the key. For individual users, this is the user's own ID.<br/>
        /// Example: user_2dHFtVWx2n56w6HkM0000000000
        /// </param>
        /// <param name="expiresAt">
        /// ISO 8601 UTC timestamp when the API key expires, or null if no expiration<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </param>
        /// <param name="externalUser">
        /// Partner's end-user identifier used for attribution.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Spending limit for the API key in USD<br/>
        /// Example: 100
        /// </param>
        /// <param name="limitRemaining">
        /// Remaining spending limit in USD<br/>
        /// Example: 74.5F
        /// </param>
        /// <param name="limitReset">
        /// Type of limit reset for the API key<br/>
        /// Example: monthly
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the API key was last updated<br/>
        /// Example: 2025-08-24T15:45:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListResponseDataItem(
            double byokUsage,
            double byokUsageDaily,
            double byokUsageMonthly,
            double byokUsageWeekly,
            string createdAt,
            bool disabled,
            string hash,
            bool includeByokInLimit,
            string label,
            string name,
            double usage,
            double usageDaily,
            double usageMonthly,
            double usageWeekly,
            string workspaceId,
            string? creatorUserId,
            global::System.DateTime? expiresAt,
            string? externalUser,
            double? limit,
            double? limitRemaining,
            string? limitReset,
            string? updatedAt)
        {
            this.ByokUsage = byokUsage;
            this.ByokUsageDaily = byokUsageDaily;
            this.ByokUsageMonthly = byokUsageMonthly;
            this.ByokUsageWeekly = byokUsageWeekly;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatorUserId = creatorUserId;
            this.Disabled = disabled;
            this.ExpiresAt = expiresAt;
            this.ExternalUser = externalUser;
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.IncludeByokInLimit = includeByokInLimit;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Limit = limit;
            this.LimitRemaining = limitRemaining;
            this.LimitReset = limitReset;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UpdatedAt = updatedAt;
            this.Usage = usage;
            this.UsageDaily = usageDaily;
            this.UsageMonthly = usageMonthly;
            this.UsageWeekly = usageWeekly;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseDataItem" /> class.
        /// </summary>
        public ListResponseDataItem()
        {
        }

    }
}