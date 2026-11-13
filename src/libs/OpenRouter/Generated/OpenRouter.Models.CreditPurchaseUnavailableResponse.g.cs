
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"error":{"code":503,"message":"The payment transfer could not be confirmed; poll the purchase before retrying","metadata":{"purchase_id":"pi_3PqXyZ2eZvKYlo2C0abc1234"}}}
    /// </summary>
    public sealed partial class CreditPurchaseUnavailableResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CreditPurchaseUnavailableResponseError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditPurchaseUnavailableResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditPurchaseUnavailableResponse(
            global::OpenRouter.CreditPurchaseUnavailableResponseError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditPurchaseUnavailableResponse" /> class.
        /// </summary>
        public CreditPurchaseUnavailableResponse()
        {
        }

    }
}