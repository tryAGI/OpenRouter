
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"expires_at":"2026-04-08T00:00:00Z","id":"ctr_01abc","skills":null}
    /// </summary>
    public sealed partial class AnthropicContainer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicContainerSkill>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicContainer" /> class.
        /// </summary>
        /// <param name="expiresAt"></param>
        /// <param name="id"></param>
        /// <param name="skills">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicContainer(
            string expiresAt,
            string id,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicContainerSkill>? skills)
        {
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicContainer" /> class.
        /// </summary>
        public AnthropicContainer()
        {
        }

    }
}