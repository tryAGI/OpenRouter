
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
    /// Example: {"cache_read":"0.00000025","cache_write":"0.000003125","completion":"0.00001","prompt":"0.0000025"}
    /// </summary>
    public sealed partial class PrivateEndpointPricing
    {
        /// <summary>
        /// USD per cache-read prompt token, as a decimal string. When omitted, inherited from the public endpoint of the same model and provider: scaled by its cache-read to prompt ratio, or left at the pricing strategy default when it publishes no cache-read rate. Required when there is no such endpoint and the provider bills cache reads.<br/>
        /// Example: 0.00000025
        /// </summary>
        /// <example>0.00000025</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read")]
        public string? CacheRead { get; set; }

        /// <summary>
        /// USD per cache-write prompt token, as a decimal string. When omitted, inherited from the public endpoint of the same model and provider: scaled by its cache-write to prompt ratio, or left at the pricing strategy default when it publishes no cache-write rate. Required when there is no such endpoint and the provider bills cache writes.<br/>
        /// Example: 0.000003125
        /// </summary>
        /// <example>0.000003125</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write")]
        public string? CacheWrite { get; set; }

        /// <summary>
        /// USD per completion token, as a decimal string.<br/>
        /// Example: 0.00001
        /// </summary>
        /// <example>0.00001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Completion { get; set; }

        /// <summary>
        /// USD per prompt token, as a decimal string.<br/>
        /// Example: 0.0000025
        /// </summary>
        /// <example>0.0000025</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointPricing" /> class.
        /// </summary>
        /// <param name="completion">
        /// USD per completion token, as a decimal string.<br/>
        /// Example: 0.00001
        /// </param>
        /// <param name="prompt">
        /// USD per prompt token, as a decimal string.<br/>
        /// Example: 0.0000025
        /// </param>
        /// <param name="cacheRead">
        /// USD per cache-read prompt token, as a decimal string. When omitted, inherited from the public endpoint of the same model and provider: scaled by its cache-read to prompt ratio, or left at the pricing strategy default when it publishes no cache-read rate. Required when there is no such endpoint and the provider bills cache reads.<br/>
        /// Example: 0.00000025
        /// </param>
        /// <param name="cacheWrite">
        /// USD per cache-write prompt token, as a decimal string. When omitted, inherited from the public endpoint of the same model and provider: scaled by its cache-write to prompt ratio, or left at the pricing strategy default when it publishes no cache-write rate. Required when there is no such endpoint and the provider bills cache writes.<br/>
        /// Example: 0.000003125
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointPricing(
            string completion,
            string prompt,
            string? cacheRead,
            string? cacheWrite)
        {
            this.CacheRead = cacheRead;
            this.CacheWrite = cacheWrite;
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointPricing" /> class.
        /// </summary>
        public PrivateEndpointPricing()
        {
        }

    }
}