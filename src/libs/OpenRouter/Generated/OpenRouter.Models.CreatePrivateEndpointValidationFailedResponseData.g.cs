
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePrivateEndpointValidationFailedResponseData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ManagedPrivateEndpointJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ManagedPrivateEndpoint Endpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation")]
        public global::OpenRouter.PrivateEndpointValidationNullable? Validation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrivateEndpointValidationFailedResponseData" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="validation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePrivateEndpointValidationFailedResponseData(
            global::OpenRouter.ManagedPrivateEndpoint endpoint,
            global::OpenRouter.PrivateEndpointValidationNullable? validation)
        {
            this.Endpoint = endpoint;
            this.Validation = validation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrivateEndpointValidationFailedResponseData" /> class.
        /// </summary>
        public CreatePrivateEndpointValidationFailedResponseData()
        {
        }

    }
}