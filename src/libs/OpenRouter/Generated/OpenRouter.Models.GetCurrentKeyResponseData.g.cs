
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Current API key information<br/>
    /// Example: {"allowed_data_regions":["global","europe","us"],"byok_usage":17.38,"byok_usage_daily":17.38,"byok_usage_monthly":17.38,"byok_usage_weekly":17.38,"creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","expires_at":"2027-12-31T23:59:59Z","free_model_daily_requests":{"limit":50,"remaining":38,"used":12},"include_byok_in_limit":false,"is_free_tier":false,"is_management_key":false,"is_provisioning_key":false,"label":"sk-or-v1-au7...890","limit":100,"limit_remaining":74.5,"limit_reset":"monthly","rate_limit":{"interval":"1h","note":"This field is deprecated and safe to ignore.","requests":1000},"usage":25.5,"usage_daily":25.5,"usage_monthly":25.5,"usage_weekly":25.5}
    /// </summary>
    public sealed partial class GetCurrentKeyResponseData
    {
        /// <summary>
        /// Data regions permitted for this API key by the guardrail policies on the key and the account regional-routing entitlement. Empty when no region is permitted. Reflects region policy only: other key restrictions, such as management keys being blocked from inference, still apply.<br/>
        /// Example: [global, europe, us]
        /// </summary>
        /// <example>[global, europe, us]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_data_regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion> AllowedDataRegions { get; set; }

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
        /// The user ID of the key creator. For organization-owned keys, this is the member who created the key. For individual users, this is the user's own ID.<br/>
        /// Example: user_2dHFtVWx2n56w6HkM0000000000
        /// </summary>
        /// <example>user_2dHFtVWx2n56w6HkM0000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_user_id")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// ISO 8601 UTC timestamp when the API key expires, or null if no expiration<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </summary>
        /// <example>2027-12-31T23:59:59Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Free-model (`:free` variant) daily request quota for the account that owns the key. Reports the same counter and tier limit that free-model enforcement reads for accounts subject to the free-model limits; the counter resets at UTC midnight. Accounts and endpoints exempt from free-model limits, and BYOK requests, are not gated by it, so `remaining` is the tier policy rather than an enforced ceiling for them.<br/>
        /// Example: {"limit":50,"remaining":38,"used":12}
        /// </summary>
        /// <example>{"limit":50,"remaining":38,"used":12}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_model_daily_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FreeModelDailyRequests FreeModelDailyRequests { get; set; }

        /// <summary>
        /// Whether to include external BYOK usage in the credit limit<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeByokInLimit { get; set; }

        /// <summary>
        /// Whether this is a free tier API key<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_free_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFreeTier { get; set; }

        /// <summary>
        /// Whether this is a management key<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_management_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsManagementKey { get; set; }

        /// <summary>
        /// Whether this is a management key<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_provisioning_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsProvisioningKey { get; set; }

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
        /// The ID of the organization that owns this API key, or null when an individual account owns it.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Legacy rate limit information about a key. Will always return -1.<br/>
        /// Example: {"interval":"1h","note":"This field is deprecated and safe to ignore.","requests":1000}
        /// </summary>
        /// <example>{"interval":"1h","note":"This field is deprecated and safe to ignore.","requests":1000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GetCurrentKeyResponseDataRateLimit RateLimit { get; set; }

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
        /// The ID of the workspace this API key spends in, or null when no active workspace resolved for it, for example because the key's workspace was deleted.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </summary>
        /// <example>0df9e665-d932-5740-b2c7-b52af166bc11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCurrentKeyResponseData" /> class.
        /// </summary>
        /// <param name="allowedDataRegions">
        /// Data regions permitted for this API key by the guardrail policies on the key and the account regional-routing entitlement. Empty when no region is permitted. Reflects region policy only: other key restrictions, such as management keys being blocked from inference, still apply.<br/>
        /// Example: [global, europe, us]
        /// </param>
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
        /// <param name="freeModelDailyRequests">
        /// Free-model (`:free` variant) daily request quota for the account that owns the key. Reports the same counter and tier limit that free-model enforcement reads for accounts subject to the free-model limits; the counter resets at UTC midnight. Accounts and endpoints exempt from free-model limits, and BYOK requests, are not gated by it, so `remaining` is the tier policy rather than an enforced ceiling for them.<br/>
        /// Example: {"limit":50,"remaining":38,"used":12}
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include external BYOK usage in the credit limit<br/>
        /// Example: false
        /// </param>
        /// <param name="isFreeTier">
        /// Whether this is a free tier API key<br/>
        /// Example: false
        /// </param>
        /// <param name="isManagementKey">
        /// Whether this is a management key<br/>
        /// Example: false
        /// </param>
        /// <param name="isProvisioningKey">
        /// Whether this is a management key<br/>
        /// Example: false
        /// </param>
        /// <param name="label">
        /// Human-readable label for the API key<br/>
        /// Example: sk-or-v1-0e6...1c96
        /// </param>
        /// <param name="rateLimit">
        /// Legacy rate limit information about a key. Will always return -1.<br/>
        /// Example: {"interval":"1h","note":"This field is deprecated and safe to ignore.","requests":1000}
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
        /// <param name="creatorUserId">
        /// The user ID of the key creator. For organization-owned keys, this is the member who created the key. For individual users, this is the user's own ID.<br/>
        /// Example: user_2dHFtVWx2n56w6HkM0000000000
        /// </param>
        /// <param name="expiresAt">
        /// ISO 8601 UTC timestamp when the API key expires, or null if no expiration<br/>
        /// Example: 2027-12-31T23:59:59Z
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
        /// <param name="organizationId">
        /// The ID of the organization that owns this API key, or null when an individual account owns it.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace this API key spends in, or null when no active workspace resolved for it, for example because the key's workspace was deleted.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCurrentKeyResponseData(
            global::System.Collections.Generic.IList<global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion> allowedDataRegions,
            double byokUsage,
            double byokUsageDaily,
            double byokUsageMonthly,
            double byokUsageWeekly,
            global::OpenRouter.FreeModelDailyRequests freeModelDailyRequests,
            bool includeByokInLimit,
            bool isFreeTier,
            bool isManagementKey,
            bool isProvisioningKey,
            string label,
            global::OpenRouter.GetCurrentKeyResponseDataRateLimit rateLimit,
            double usage,
            double usageDaily,
            double usageMonthly,
            double usageWeekly,
            string? creatorUserId,
            global::System.DateTime? expiresAt,
            double? limit,
            double? limitRemaining,
            string? limitReset,
            string? organizationId,
            string? workspaceId)
        {
            this.AllowedDataRegions = allowedDataRegions ?? throw new global::System.ArgumentNullException(nameof(allowedDataRegions));
            this.ByokUsage = byokUsage;
            this.ByokUsageDaily = byokUsageDaily;
            this.ByokUsageMonthly = byokUsageMonthly;
            this.ByokUsageWeekly = byokUsageWeekly;
            this.CreatorUserId = creatorUserId;
            this.ExpiresAt = expiresAt;
            this.FreeModelDailyRequests = freeModelDailyRequests ?? throw new global::System.ArgumentNullException(nameof(freeModelDailyRequests));
            this.IncludeByokInLimit = includeByokInLimit;
            this.IsFreeTier = isFreeTier;
            this.IsManagementKey = isManagementKey;
            this.IsProvisioningKey = isProvisioningKey;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Limit = limit;
            this.LimitRemaining = limitRemaining;
            this.LimitReset = limitReset;
            this.OrganizationId = organizationId;
            this.RateLimit = rateLimit ?? throw new global::System.ArgumentNullException(nameof(rateLimit));
            this.Usage = usage;
            this.UsageDaily = usageDaily;
            this.UsageMonthly = usageMonthly;
            this.UsageWeekly = usageWeekly;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCurrentKeyResponseData" /> class.
        /// </summary>
        public GetCurrentKeyResponseData()
        {
        }

    }
}