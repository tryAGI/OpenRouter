
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"allow_safety_retention_google":null,"allowed_models":null,"allowed_providers":["openai","anthropic","google"],"content_filter_builtins":[{"action":"redact","label":"[EMAIL]","slug":"email"}],"content_filters":null,"created_at":"2025-08-24T10:30:00Z","description":"Guardrail for production environment","enable_free_model_publication":false,"enable_free_model_training":true,"enable_paid_model_training":true,"enforce_zdr":null,"enforce_zdr_anthropic":true,"enforce_zdr_google":false,"enforce_zdr_openai":true,"enforce_zdr_other":false,"enforce_zdr_xai":false,"id":"550e8400-e29b-41d4-a716-446655440000","ignored_models":null,"ignored_providers":null,"include_byok_in_budgets":false,"limit_usd":100,"name":"Production Guardrail","reset_interval":"monthly","updated_at":"2025-08-24T15:45:00Z","workspace_id":"0df9e665-d932-5740-b2c7-b52af166bc11"}],"total_count":1}
    /// </summary>
    public sealed partial class ListGuardrailsResponse
    {
        /// <summary>
        /// List of guardrails
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.Guardrail> Data { get; set; }

        /// <summary>
        /// Total number of guardrails<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGuardrailsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of guardrails
        /// </param>
        /// <param name="totalCount">
        /// Total number of guardrails<br/>
        /// Example: 25
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGuardrailsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.Guardrail> data,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGuardrailsResponse" /> class.
        /// </summary>
        public ListGuardrailsResponse()
        {
        }

    }
}