
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedPrivateEndpointVariant2
    {
        /// <summary>
        /// Where you attest this deployment processes data. `global` means not regional; `null` means undeclared.<br/>
        /// Example: us
        /// </summary>
        /// <example>us</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PrivateEndpointDeclaredRegionJsonConverter))]
        public global::OpenRouter.PrivateEndpointDeclaredRegion? DeclaredRegion { get; set; }

        /// <summary>
        /// Whether you attest this deployment retains no prompt or completion data. `null` means undeclared.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_zdr")]
        public bool? DeclaredZdr { get; set; }

        /// <summary>
        /// Most completion tokens a request routed to this endpoint can produce, or `null` when the endpoint sets no cap beyond the model context length.<br/>
        /// Example: 131072
        /// </summary>
        /// <example>131072</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedPrivateEndpointVariant2" /> class.
        /// </summary>
        /// <param name="declaredRegion">
        /// Where you attest this deployment processes data. `global` means not regional; `null` means undeclared.<br/>
        /// Example: us
        /// </param>
        /// <param name="declaredZdr">
        /// Whether you attest this deployment retains no prompt or completion data. `null` means undeclared.<br/>
        /// Example: true
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Most completion tokens a request routed to this endpoint can produce, or `null` when the endpoint sets no cap beyond the model context length.<br/>
        /// Example: 131072
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedPrivateEndpointVariant2(
            global::OpenRouter.PrivateEndpointDeclaredRegion? declaredRegion,
            bool? declaredZdr,
            int? maxCompletionTokens)
        {
            this.DeclaredRegion = declaredRegion;
            this.DeclaredZdr = declaredZdr;
            this.MaxCompletionTokens = maxCompletionTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedPrivateEndpointVariant2" /> class.
        /// </summary>
        public ManagedPrivateEndpointVariant2()
        {
        }

    }
}