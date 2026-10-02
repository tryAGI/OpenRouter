
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchSubmitBodyRequest
    {
        /// <summary>
        /// Request payload for the batch `endpoint`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSubmitBodyRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// Request payload for the batch `endpoint`.
        /// </param>
        /// <param name="customId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchSubmitBodyRequest(
            object body,
            string customId)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CustomId = customId ?? throw new global::System.ArgumentNullException(nameof(customId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSubmitBodyRequest" /> class.
        /// </summary>
        public BatchSubmitBodyRequest()
        {
        }

    }
}