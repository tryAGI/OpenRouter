
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePrivateProviderResponse
    {
        /// <summary>
        /// Example: {"base_url":"https://inference.example.com/v1","created_at":"2026-10-06T12:00:00.000Z","data_policy":{"prompt_retention_days":null,"retains_prompts":false,"training":false},"display_name":"Acme","name":"Acme","slug":"acme"}
        /// </summary>
        /// <example>{"base_url":"https://inference.example.com/v1","created_at":"2026-10-06T12:00:00.000Z","data_policy":{"prompt_retention_days":null,"retains_prompts":false,"training":false},"display_name":"Acme","name":"Acme","slug":"acme"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateProvider Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateProviderResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: {"base_url":"https://inference.example.com/v1","created_at":"2026-10-06T12:00:00.000Z","data_policy":{"prompt_retention_days":null,"retains_prompts":false,"training":false},"display_name":"Acme","name":"Acme","slug":"acme"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrivateProviderResponse(
            global::OpenRouter.PrivateProvider data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateProviderResponse" /> class.
        /// </summary>
        public UpdatePrivateProviderResponse()
        {
        }

    }
}