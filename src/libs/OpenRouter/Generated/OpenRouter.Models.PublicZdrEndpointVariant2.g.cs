
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicZdrEndpointVariant2
    {
        /// <summary>
        /// Whether the endpoint uses Safety Retention: prompts are not retained by default, but the provider may retain prompts its safety classifiers flag. A ZDR-enforced request reaches these endpoints only when the account allows Safety Retention and no applied guardrail disallows it.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_retention")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SafetyRetention { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicZdrEndpointVariant2" /> class.
        /// </summary>
        /// <param name="safetyRetention">
        /// Whether the endpoint uses Safety Retention: prompts are not retained by default, but the provider may retain prompts its safety classifiers flag. A ZDR-enforced request reaches these endpoints only when the account allows Safety Retention and no applied guardrail disallows it.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicZdrEndpointVariant2(
            bool safetyRetention)
        {
            this.SafetyRetention = safetyRetention;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicZdrEndpointVariant2" /> class.
        /// </summary>
        public PublicZdrEndpointVariant2()
        {
        }

    }
}