
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateEndpointValidation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointCheck> Checks { get; set; }

        /// <summary>
        /// Whether every check passed.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointValidation" /> class.
        /// </summary>
        /// <param name="checks"></param>
        /// <param name="passed">
        /// Whether every check passed.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointValidation(
            global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointCheck> checks,
            bool passed)
        {
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
            this.Passed = passed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointValidation" /> class.
        /// </summary>
        public PrivateEndpointValidation()
        {
        }

    }
}