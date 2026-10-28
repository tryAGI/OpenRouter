
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateEndpointValidationNullable
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointCheck> Checks { get; set; }

        /// <summary>
        /// Request parameters probed after the checks passed, each with whether the upstream honored it. Supported ones are recorded in `tested_parameters`. Absent on a failed run and for providers that run no parameter probes; empty when every probe group was already proven.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointParameterCheck>? Parameters { get; set; }

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
        /// Initializes a new instance of the <see cref="PrivateEndpointValidationNullable" /> class.
        /// </summary>
        /// <param name="checks"></param>
        /// <param name="passed">
        /// Whether every check passed.<br/>
        /// Example: true
        /// </param>
        /// <param name="parameters">
        /// Request parameters probed after the checks passed, each with whether the upstream honored it. Supported ones are recorded in `tested_parameters`. Absent on a failed run and for providers that run no parameter probes; empty when every probe group was already proven.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointValidationNullable(
            global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointCheck> checks,
            bool passed,
            global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointParameterCheck>? parameters)
        {
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
            this.Parameters = parameters;
            this.Passed = passed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointValidationNullable" /> class.
        /// </summary>
        public PrivateEndpointValidationNullable()
        {
        }

    }
}