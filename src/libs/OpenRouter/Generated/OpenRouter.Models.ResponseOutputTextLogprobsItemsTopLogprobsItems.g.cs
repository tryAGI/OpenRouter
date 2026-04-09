
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseOutputTextLogprobsItemsTopLogprobsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<long> Bytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextLogprobsItemsTopLogprobsItems" /> class.
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="logprob"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputTextLogprobsItemsTopLogprobsItems(
            global::System.Collections.Generic.IList<long> bytes,
            double logprob,
            string token)
        {
            this.Bytes = bytes ?? throw new global::System.ArgumentNullException(nameof(bytes));
            this.Logprob = logprob;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextLogprobsItemsTopLogprobsItems" /> class.
        /// </summary>
        public ResponseOutputTextLogprobsItemsTopLogprobsItems()
        {
        }
    }
}