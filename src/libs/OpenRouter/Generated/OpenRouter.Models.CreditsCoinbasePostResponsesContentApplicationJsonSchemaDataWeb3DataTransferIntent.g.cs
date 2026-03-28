
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentCallData CallData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntent" /> class.
        /// </summary>
        /// <param name="callData"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntent(
            global::OpenRouter.CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentCallData callData,
            global::OpenRouter.CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentMetadata metadata)
        {
            this.CallData = callData ?? throw new global::System.ArgumentNullException(nameof(callData));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntent" /> class.
        /// </summary>
        public CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntent()
        {
        }
    }
}