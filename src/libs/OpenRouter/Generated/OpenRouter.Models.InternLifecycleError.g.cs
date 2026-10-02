
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Intern lifecycle request failure.<br/>
    /// Example: {"error":{"code":404,"message":"Intern not found","metadata":{"reason":"not_found","retryable":false}}}
    /// </summary>
    public sealed partial class InternLifecycleError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternLifecycleErrorError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternLifecycleError" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternLifecycleError(
            global::OpenRouter.InternLifecycleErrorError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternLifecycleError" /> class.
        /// </summary>
        public InternLifecycleError()
        {
        }

    }
}