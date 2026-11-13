
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Present when the outcome of a paid request is unknown and its purchase is known.
    /// </summary>
    public sealed partial class CreditPurchaseUnavailableResponseErrorMetadata
    {
        /// <summary>
        /// The purchase to poll with `GET /api/v1/credits/purchases/{id}` before paying again.<br/>
        /// Example: pi_3PqXyZ2eZvKYlo2C0abc1234
        /// </summary>
        /// <example>pi_3PqXyZ2eZvKYlo2C0abc1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PurchaseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditPurchaseUnavailableResponseErrorMetadata" /> class.
        /// </summary>
        /// <param name="purchaseId">
        /// The purchase to poll with `GET /api/v1/credits/purchases/{id}` before paying again.<br/>
        /// Example: pi_3PqXyZ2eZvKYlo2C0abc1234
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditPurchaseUnavailableResponseErrorMetadata(
            string purchaseId)
        {
            this.PurchaseId = purchaseId ?? throw new global::System.ArgumentNullException(nameof(purchaseId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditPurchaseUnavailableResponseErrorMetadata" /> class.
        /// </summary>
        public CreditPurchaseUnavailableResponseErrorMetadata()
        {
        }

    }
}