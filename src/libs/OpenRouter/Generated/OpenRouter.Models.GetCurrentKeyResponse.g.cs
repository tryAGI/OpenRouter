
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"allowed_data_regions":["global","europe","us"],"byok_usage":17.38,"byok_usage_daily":17.38,"byok_usage_monthly":17.38,"byok_usage_weekly":17.38,"creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","expires_at":"2027-12-31T23:59:59Z","free_model_daily_requests":{"limit":50,"remaining":38,"used":12},"include_byok_in_limit":false,"is_free_tier":false,"is_management_key":false,"is_provisioning_key":false,"label":"sk-or-v1-au7...890","limit":100,"limit_remaining":74.5,"limit_reset":"monthly","rate_limit":{"interval":"1h","note":"This field is deprecated and safe to ignore.","requests":1000},"usage":25.5,"usage_daily":25.5,"usage_monthly":25.5,"usage_weekly":25.5}}
    /// </summary>
    public sealed partial class GetCurrentKeyResponse
    {
        /// <summary>
        /// Current API key information<br/>
        /// Example: {"allowed_data_regions":["global","europe","us"],"byok_usage":17.38,"byok_usage_daily":17.38,"byok_usage_monthly":17.38,"byok_usage_weekly":17.38,"creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","expires_at":"2027-12-31T23:59:59Z","free_model_daily_requests":{"limit":50,"remaining":38,"used":12},"include_byok_in_limit":false,"is_free_tier":false,"is_management_key":false,"is_provisioning_key":false,"label":"sk-or-v1-au7...890","limit":100,"limit_remaining":74.5,"limit_reset":"monthly","rate_limit":{"interval":"1h","note":"This field is deprecated and safe to ignore.","requests":1000},"usage":25.5,"usage_daily":25.5,"usage_monthly":25.5,"usage_weekly":25.5}
        /// </summary>
        /// <example>{"allowed_data_regions":["global","europe","us"],"byok_usage":17.38,"byok_usage_daily":17.38,"byok_usage_monthly":17.38,"byok_usage_weekly":17.38,"creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","expires_at":"2027-12-31T23:59:59Z","free_model_daily_requests":{"limit":50,"remaining":38,"used":12},"include_byok_in_limit":false,"is_free_tier":false,"is_management_key":false,"is_provisioning_key":false,"label":"sk-or-v1-au7...890","limit":100,"limit_remaining":74.5,"limit_reset":"monthly","rate_limit":{"interval":"1h","note":"This field is deprecated and safe to ignore.","requests":1000},"usage":25.5,"usage_daily":25.5,"usage_monthly":25.5,"usage_weekly":25.5}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GetCurrentKeyResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCurrentKeyResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Current API key information<br/>
        /// Example: {"allowed_data_regions":["global","europe","us"],"byok_usage":17.38,"byok_usage_daily":17.38,"byok_usage_monthly":17.38,"byok_usage_weekly":17.38,"creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","expires_at":"2027-12-31T23:59:59Z","free_model_daily_requests":{"limit":50,"remaining":38,"used":12},"include_byok_in_limit":false,"is_free_tier":false,"is_management_key":false,"is_provisioning_key":false,"label":"sk-or-v1-au7...890","limit":100,"limit_remaining":74.5,"limit_reset":"monthly","rate_limit":{"interval":"1h","note":"This field is deprecated and safe to ignore.","requests":1000},"usage":25.5,"usage_daily":25.5,"usage_monthly":25.5,"usage_weekly":25.5}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCurrentKeyResponse(
            global::OpenRouter.GetCurrentKeyResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCurrentKeyResponse" /> class.
        /// </summary>
        public GetCurrentKeyResponse()
        {
        }

    }
}