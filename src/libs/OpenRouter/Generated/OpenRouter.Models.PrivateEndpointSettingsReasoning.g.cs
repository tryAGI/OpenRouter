
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateEndpointSettingsReasoning
    {
        /// <summary>
        /// Where the upstream puts reasoning tokens in its response: `reasoning` and `reasoning-content` are response fields, `content-string` is inline in the message, `none` returns no reasoning. `null` uses the provider default.<br/>
        /// Example: reasoning
        /// </summary>
        /// <example>reasoning</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_mechanism")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PrivateEndpointReasoningReturnMechanismJsonConverter))]
        public global::OpenRouter.PrivateEndpointReasoningReturnMechanism? ReturnMechanism { get; set; }

        /// <summary>
        /// Whether requests with `reasoning` route to this endpoint.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointSettingsReasoning" /> class.
        /// </summary>
        /// <param name="supported">
        /// Whether requests with `reasoning` route to this endpoint.<br/>
        /// Example: true
        /// </param>
        /// <param name="returnMechanism">
        /// Where the upstream puts reasoning tokens in its response: `reasoning` and `reasoning-content` are response fields, `content-string` is inline in the message, `none` returns no reasoning. `null` uses the provider default.<br/>
        /// Example: reasoning
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointSettingsReasoning(
            bool supported,
            global::OpenRouter.PrivateEndpointReasoningReturnMechanism? returnMechanism)
        {
            this.ReturnMechanism = returnMechanism;
            this.Supported = supported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointSettingsReasoning" /> class.
        /// </summary>
        public PrivateEndpointSettingsReasoning()
        {
        }

    }
}