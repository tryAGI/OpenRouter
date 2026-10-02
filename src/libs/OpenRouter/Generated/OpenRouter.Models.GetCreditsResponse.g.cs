
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Total credits purchased and used<br/>
    /// Example: {"data":{"total_credits":100.5,"total_usage":25.75}}
    /// </summary>
    public sealed partial class GetCreditsResponse
    {
        /// <summary>
        /// Example: {"total_credits":100.5,"total_usage":25.75}
        /// </summary>
        /// <example>{"total_credits":100.5,"total_usage":25.75}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GetCreditsResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreditsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: {"total_credits":100.5,"total_usage":25.75}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCreditsResponse(
            global::OpenRouter.GetCreditsResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreditsResponse" /> class.
        /// </summary>
        public GetCreditsResponse()
        {
        }

    }
}