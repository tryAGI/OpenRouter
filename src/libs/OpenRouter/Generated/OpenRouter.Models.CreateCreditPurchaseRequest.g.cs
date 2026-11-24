
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCreditPurchaseRequest(
            string creditAmountUsd)
        {
            this.CreditAmountUsd = creditAmountUsd ?? throw new global::System.ArgumentNullException(nameof(creditAmountUsd));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCreditPurchaseRequest" /> class.
        /// </summary>
        public CreateCreditPurchaseRequest()
        {
        }

    }
}