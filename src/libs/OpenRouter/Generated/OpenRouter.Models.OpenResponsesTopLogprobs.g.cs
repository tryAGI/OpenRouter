
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Alternative token with its log probability<br/>
    /// Example: {"logprob":-0.5,"token":"hello"}
    /// </summary>
    public sealed partial class OpenResponsesTopLogprobs
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
        public double? Logprob { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesTopLogprobs" /> class.
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="logprob"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenResponsesTopLogprobs(
            global::System.Collections.Generic.IList<long>? bytes,
            double? logprob,
            string? token)
        {
            this.Bytes = bytes;
            this.Logprob = logprob;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesTopLogprobs" /> class.
        /// </summary>
        public OpenResponsesTopLogprobs()
        {
        }

    }
}