
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Log probability information for a token<br/>
    /// Example: {"logprob":-0.1,"token":"world","top_logprobs":[{"logprob":-0.5,"token":"hello"}]}
    /// </summary>
    public sealed partial class OpenResponsesLogProbs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public global::System.Collections.Generic.IList<long>? Bytes { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesTopLogprobs>? TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesLogProbs" /> class.
        /// </summary>
        /// <param name="logprob"></param>
        /// <param name="token"></param>
        /// <param name="bytes"></param>
        /// <param name="topLogprobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenResponsesLogProbs(
            double logprob,
            string token,
            global::System.Collections.Generic.IList<long>? bytes,
            global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesTopLogprobs>? topLogprobs)
        {
            this.Bytes = bytes;
            this.Logprob = logprob;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.TopLogprobs = topLogprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesLogProbs" /> class.
        /// </summary>
        public OpenResponsesLogProbs()
        {
        }

    }
}