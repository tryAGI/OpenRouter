
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"allowed_models":null,"allowed_providers":["openai"],"content_filter_builtins":[{"action":"redact","label":"[EMAIL]","slug":"email"}],"content_filters":null,"created_at":"2025-08-24T10:30:00Z","description":"Updated description","enable_free_model_publication":false,"enable_free_model_training":true,"enable_paid_model_training":true,"enforce_zdr":null,"enforce_zdr_anthropic":true,"enforce_zdr_google":true,"enforce_zdr_openai":true,"enforce_zdr_other":true,"enforce_zdr_xai":true,"id":"550e8400-e29b-41d4-a716-446655440000","ignored_models":null,"ignored_providers":null,"include_byok_in_budgets":true,"limit_usd":75,"name":"Updated Guardrail Name","reset_interval":"weekly","updated_at":"2025-08-24T16:00:00Z","workspace_id":"0df9e665-d932-5740-b2c7-b52af166bc11"}}
    /// </summary>
    public sealed partial class UpdateGuardrailResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.Guardrail, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AllOf<global::OpenRouter.Guardrail, object> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGuardrailResponse(
            global::OpenRouter.AllOf<global::OpenRouter.Guardrail, object> data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailResponse" /> class.
        /// </summary>
        public UpdateGuardrailResponse()
        {
        }

    }
}