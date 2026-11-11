
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreditPurchasePaymentRequired
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challengeId")]
        public string? ChallengeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// The agent setup guide, `GET /api/v1/credits/purchases/setup`.<br/>
        /// Example: https://openrouter.ai/api/v1/credits/purchases/setup
        /// </summary>
        /// <example>https://openrouter.ai/api/v1/credits/purchases/setup</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Setup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Example: https://paymentauth.org/problems/payment-required
        /// </summary>
        /// <example>https://paymentauth.org/problems/payment-required</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditPurchasePaymentRequired" /> class.
        /// </summary>
        /// <param name="setup">
        /// The agent setup guide, `GET /api/v1/credits/purchases/setup`.<br/>
        /// Example: https://openrouter.ai/api/v1/credits/purchases/setup
        /// </param>
        /// <param name="status"></param>
        /// <param name="title"></param>
        /// <param name="type">
        /// Example: https://paymentauth.org/problems/payment-required
        /// </param>
        /// <param name="challengeId"></param>
        /// <param name="detail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditPurchasePaymentRequired(
            string setup,
            double status,
            string title,
            string type,
            string? challengeId,
            string? detail)
        {
            this.ChallengeId = challengeId;
            this.Detail = detail;
            this.Setup = setup ?? throw new global::System.ArgumentNullException(nameof(setup));
            this.Status = status;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditPurchasePaymentRequired" /> class.
        /// </summary>
        public CreditPurchasePaymentRequired()
        {
        }

    }
}