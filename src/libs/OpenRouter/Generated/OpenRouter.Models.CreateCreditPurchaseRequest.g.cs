
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCreditPurchaseRequest
    {
        /// <summary>
        /// Credits to buy, in USD with at most two decimals. The platform fee is added on top and shown in the challenge and the receipt.<br/>
        /// Example: 25.00
        /// </summary>
        /// <example>25.00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_amount_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreditAmountUsd { get; set; }

        /// <summary>
        /// Payment protocol. Defaults to MPP on Tempo; x402 pays USDC on Base when enabled. Keep the protocol and Idempotency-Key unchanged on retries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateCreditPurchaseRequestProtocolJsonConverter))]
        public global::OpenRouter.CreateCreditPurchaseRequestProtocol? Protocol { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditPurchaseRequest" /> class.
        /// </summary>
        /// <param name="creditAmountUsd">
        /// Credits to buy, in USD with at most two decimals. The platform fee is added on top and shown in the challenge and the receipt.<br/>
        /// Example: 25.00
        /// </param>
        /// <param name="protocol">
        /// Payment protocol. Defaults to MPP on Tempo; x402 pays USDC on Base when enabled. Keep the protocol and Idempotency-Key unchanged on retries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCreditPurchaseRequest(
            string creditAmountUsd,
            global::OpenRouter.CreateCreditPurchaseRequestProtocol? protocol)
        {
            this.CreditAmountUsd = creditAmountUsd ?? throw new global::System.ArgumentNullException(nameof(creditAmountUsd));
            this.Protocol = protocol;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditPurchaseRequest" /> class.
        /// </summary>
        public CreateCreditPurchaseRequest()
        {
        }

    }
}