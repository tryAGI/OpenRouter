
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedPrivateEndpointVariant2(
            global::OpenRouter.PrivateEndpointDeclaredRegion? declaredRegion,
            bool? declaredZdr)
        {
            this.DeclaredRegion = declaredRegion;
            this.DeclaredZdr = declaredZdr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedPrivateEndpointVariant2" /> class.
        /// </summary>
        public ManagedPrivateEndpointVariant2()
        {
        }

    }
}