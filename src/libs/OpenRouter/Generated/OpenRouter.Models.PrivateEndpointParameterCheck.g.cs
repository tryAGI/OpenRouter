
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"parameter":"response_format","supported":true}
    /// </summary>
    public sealed partial class PrivateEndpointParameterCheck
    {
        /// <summary>
        /// Example: response_format
        /// </summary>
        /// <example>response_format</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Parameter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointParameterCheck" /> class.
        /// </summary>
        /// <param name="parameter">
        /// Example: response_format
        /// </param>
        /// <param name="supported"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointParameterCheck(
            string parameter,
            bool supported)
        {
            this.Parameter = parameter ?? throw new global::System.ArgumentNullException(nameof(parameter));
            this.Supported = supported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointParameterCheck" /> class.
        /// </summary>
        public PrivateEndpointParameterCheck()
        {
        }

    }
}