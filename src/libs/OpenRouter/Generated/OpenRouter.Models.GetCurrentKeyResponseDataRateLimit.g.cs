
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Legacy rate limit information about a key. Will always return -1.<br/>
    /// Example: {"interval":"1h","note":"This field is deprecated and safe to ignore.","requests":1000}
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetCurrentKeyResponseDataRateLimit
    {
        /// <summary>
        /// Rate limit interval<br/>
        /// Example: 1h
        /// </summary>
        /// <example>1h</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Interval { get; set; }

        /// <summary>
        /// Note about the rate limit<br/>
        /// Example: This field is deprecated and safe to ignore.
        /// </summary>
        /// <example>This field is deprecated and safe to ignore.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Note { get; set; }

        /// <summary>
        /// Number of requests allowed per interval<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required int Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCurrentKeyResponseDataRateLimit" /> class.
        /// </summary>
        /// <param name="interval">
        /// Rate limit interval<br/>
        /// Example: 1h
        /// </param>
        /// <param name="note">
        /// Note about the rate limit<br/>
        /// Example: This field is deprecated and safe to ignore.
        /// </param>
        /// <param name="requests">
        /// Number of requests allowed per interval<br/>
        /// Example: 1000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCurrentKeyResponseDataRateLimit(
            string interval,
            string note,
            int requests)
        {
            this.Interval = interval ?? throw new global::System.ArgumentNullException(nameof(interval));
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCurrentKeyResponseDataRateLimit" /> class.
        /// </summary>
        public GetCurrentKeyResponseDataRateLimit()
        {
        }

    }
}