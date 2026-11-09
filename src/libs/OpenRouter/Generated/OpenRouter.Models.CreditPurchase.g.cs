
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreditPurchase
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_amount_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreditAmountUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// Opaque purchase id, owned by the calling account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Network { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_intent_id")]
        public string? PaymentIntentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_fee_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlatformFeeUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Protocol { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreditPurchaseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CreditPurchaseStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_charged_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalChargedUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditPurchase" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="creditAmountUsd"></param>
        /// <param name="id">
        /// Opaque purchase id, owned by the calling account.
        /// </param>
        /// <param name="network"></param>
        /// <param name="platformFeeUsd"></param>
        /// <param name="protocol"></param>
        /// <param name="status"></param>
        /// <param name="totalChargedUsd"></param>
        /// <param name="failureReason"></param>
        /// <param name="paymentIntentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditPurchase(
            string createdAt,
            string creditAmountUsd,
            string id,
            string network,
            string platformFeeUsd,
            string protocol,
            global::OpenRouter.CreditPurchaseStatus status,
            string totalChargedUsd,
            string? failureReason,
            string? paymentIntentId)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreditAmountUsd = creditAmountUsd ?? throw new global::System.ArgumentNullException(nameof(creditAmountUsd));
            this.FailureReason = failureReason;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Network = network ?? throw new global::System.ArgumentNullException(nameof(network));
            this.PaymentIntentId = paymentIntentId;
            this.PlatformFeeUsd = platformFeeUsd ?? throw new global::System.ArgumentNullException(nameof(platformFeeUsd));
            this.Protocol = protocol ?? throw new global::System.ArgumentNullException(nameof(protocol));
            this.Status = status;
            this.TotalChargedUsd = totalChargedUsd ?? throw new global::System.ArgumentNullException(nameof(totalChargedUsd));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditPurchase" /> class.
        /// </summary>
        public CreditPurchase()
        {
        }

    }
}