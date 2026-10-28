
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePrivateEndpointParametersRequest
    {
        /// <summary>
        /// Parameters the upstream supports beyond the tested ones. Replaces the earlier declaration; tested parameters stay. Order and repeated names are ignored, but the list holds at most as many entries as there are declarable parameters, repeats included. `tool_choice` requires `tools` to be tested or declared.<br/>
        /// Example: [temperature, seed]
        /// </summary>
        /// <example>[temperature, seed]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointDeclaredParameter> DeclaredParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointParametersRequest" /> class.
        /// </summary>
        /// <param name="declaredParameters">
        /// Parameters the upstream supports beyond the tested ones. Replaces the earlier declaration; tested parameters stay. Order and repeated names are ignored, but the list holds at most as many entries as there are declarable parameters, repeats included. `tool_choice` requires `tools` to be tested or declared.<br/>
        /// Example: [temperature, seed]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrivateEndpointParametersRequest(
            global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointDeclaredParameter> declaredParameters)
        {
            this.DeclaredParameters = declaredParameters ?? throw new global::System.ArgumentNullException(nameof(declaredParameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointParametersRequest" /> class.
        /// </summary>
        public UpdatePrivateEndpointParametersRequest()
        {
        }

    }
}