
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Payment Required - Insufficient credits or quota to complete request<br/>
    /// Example: {"error":{"code":402,"message":"Insufficient credits. Add more using https://openrouter.ai/credits"}}
    /// </summary>
    public sealed partial class PaymentRequiredResponse
    {
        /// <summary>
        /// Error data for PaymentRequiredResponse<br/>
        /// Example: {"code":402,"message":"Insufficient credits. Add more using https://openrouter.ai/credits"}
        /// </summary>
        /// <example>{"code":402,"message":"Insufficient credits. Add more using https://openrouter.ai/credits"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PaymentRequiredResponseErrorData Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter_metadata")]
        public object? OpenrouterMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequiredResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for PaymentRequiredResponse<br/>
        /// Example: {"code":402,"message":"Insufficient credits. Add more using https://openrouter.ai/credits"}
        /// </param>
        /// <param name="openrouterMetadata"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentRequiredResponse(
            global::OpenRouter.PaymentRequiredResponseErrorData error,
            object? openrouterMetadata,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.OpenrouterMetadata = openrouterMetadata;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequiredResponse" /> class.
        /// </summary>
        public PaymentRequiredResponse()
        {
        }

    }
}