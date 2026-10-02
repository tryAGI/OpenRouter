
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
    /// Example: {"completion":"0.00001","prompt":"0.0000025"}
    /// </summary>
    public sealed partial class PrivateEndpointPricing
    {
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointPricing(
            string completion,
            string prompt)
        {
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