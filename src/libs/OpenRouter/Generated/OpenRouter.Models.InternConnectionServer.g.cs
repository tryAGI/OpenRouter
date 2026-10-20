
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InternConnectionServer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("surface")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Surface { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transport { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternConnectionServer" /> class.
        /// </summary>
        /// <param name="surface"></param>
        /// <param name="transport"></param>
        /// <param name="host"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternConnectionServer(
            string surface,
            string transport,
            string? host,
            string? url)
        {
            this.Host = host;
            this.Surface = surface ?? throw new global::System.ArgumentNullException(nameof(surface));
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternConnectionServer" /> class.
        /// </summary>
        public InternConnectionServer()
        {
        }

    }
}