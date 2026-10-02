
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"byok_usage":17.38,"byok_usage_daily":17.38,"byok_usage_monthly":17.38,"byok_usage_weekly":17.38,"created_at":"2025-08-24T10:30:00Z","creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","disabled":false,"expires_at":"2027-12-31T23:59:59Z","external_user":null,"hash":"f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943","include_byok_in_limit":false,"label":"Production API Key","limit":100,"limit_remaining":74.5,"limit_reset":"monthly","name":"My Production Key","updated_at":"2025-08-24T15:45:00Z","usage":25.5,"usage_daily":25.5,"usage_monthly":25.5,"usage_weekly":25.5,"workspace_id":"0df9e665-d932-5740-b2c7-b52af166bc11"}}
    /// </summary>
    public sealed partial class GetKeyResponse
    {
        /// <summary>
        /// The API key information<br/>
        /// Example: {"byok_usage":17.38,"byok_usage_daily":17.38,"byok_usage_monthly":17.38,"byok_usage_weekly":17.38,"created_at":"2025-08-24T10:30:00Z","creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","disabled":false,"expires_at":"2027-12-31T23:59:59Z","external_user":null,"hash":"f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943","include_byok_in_limit":false,"label":"sk-or-v1-0e6...1c96","limit":100,"limit_remaining":74.5,"limit_reset":"monthly","name":"My Production Key","updated_at":"2025-08-24T15:45:00Z","usage":25.5,"usage_daily":25.5,"usage_monthly":25.5,"usage_weekly":25.5,"workspace_id":"0df9e665-d932-5740-b2c7-b52af166bc11"}
        /// </summary>
        /// <example>{"byok_usage":17.38,"byok_usage_daily":17.38,"byok_usage_monthly":17.38,"byok_usage_weekly":17.38,"created_at":"2025-08-24T10:30:00Z","creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","disabled":false,"expires_at":"2027-12-31T23:59:59Z","external_user":null,"hash":"f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943","include_byok_in_limit":false,"label":"sk-or-v1-0e6...1c96","limit":100,"limit_remaining":74.5,"limit_reset":"monthly","name":"My Production Key","updated_at":"2025-08-24T15:45:00Z","usage":25.5,"usage_daily":25.5,"usage_monthly":25.5,"usage_weekly":25.5,"workspace_id":"0df9e665-d932-5740-b2c7-b52af166bc11"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GetKeyResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKeyResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The API key information<br/>
        /// Example: {"byok_usage":17.38,"byok_usage_daily":17.38,"byok_usage_monthly":17.38,"byok_usage_weekly":17.38,"created_at":"2025-08-24T10:30:00Z","creator_user_id":"user_2dHFtVWx2n56w6HkM0000000000","disabled":false,"expires_at":"2027-12-31T23:59:59Z","external_user":null,"hash":"f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943","include_byok_in_limit":false,"label":"sk-or-v1-0e6...1c96","limit":100,"limit_remaining":74.5,"limit_reset":"monthly","name":"My Production Key","updated_at":"2025-08-24T15:45:00Z","usage":25.5,"usage_daily":25.5,"usage_monthly":25.5,"usage_weekly":25.5,"workspace_id":"0df9e665-d932-5740-b2c7-b52af166bc11"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKeyResponse(
            global::OpenRouter.GetKeyResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKeyResponse" /> class.
        /// </summary>
        public GetKeyResponse()
        {
        }

    }
}