
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"name":"auth_ok","passed":true}
    /// </summary>
    public sealed partial class PrivateEndpointCheck
    {
        /// <summary>
        /// Model the upstream reported serving, when it differs from the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual_model")]
        public string? ActualModel { get; set; }

        /// <summary>
        /// Check name.<br/>
        /// Example: auth_ok
        /// </summary>
        /// <example>auth_ok</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// Why the check failed.<br/>
        /// Example: no_byok_key
        /// </summary>
        /// <example>no_byok_key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PrivateEndpointCheckReasonJsonConverter))]
        public global::OpenRouter.PrivateEndpointCheckReason? Reason { get; set; }

        /// <summary>
        /// Error message returned by your deployment when the call failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_message")]
        public string? UpstreamMessage { get; set; }

        /// <summary>
        /// HTTP status returned by your deployment when the call failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_status")]
        public int? UpstreamStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointCheck" /> class.
        /// </summary>
        /// <param name="name">
        /// Check name.<br/>
        /// Example: auth_ok
        /// </param>
        /// <param name="passed"></param>
        /// <param name="actualModel">
        /// Model the upstream reported serving, when it differs from the request.
        /// </param>
        /// <param name="reason">
        /// Why the check failed.<br/>
        /// Example: no_byok_key
        /// </param>
        /// <param name="upstreamMessage">
        /// Error message returned by your deployment when the call failed.
        /// </param>
        /// <param name="upstreamStatus">
        /// HTTP status returned by your deployment when the call failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointCheck(
            string name,
            bool passed,
            string? actualModel,
            global::OpenRouter.PrivateEndpointCheckReason? reason,
            string? upstreamMessage,
            int? upstreamStatus)
        {
            this.ActualModel = actualModel;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Passed = passed;
            this.Reason = reason;
            this.UpstreamMessage = upstreamMessage;
            this.UpstreamStatus = upstreamStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointCheck" /> class.
        /// </summary>
        public PrivateEndpointCheck()
        {
        }

    }
}