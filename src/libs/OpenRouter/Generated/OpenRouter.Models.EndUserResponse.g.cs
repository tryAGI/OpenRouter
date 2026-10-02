
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"created_at":"2026-09-16T12:00:00Z","is_active":true,"updated_at":"2026-09-16T12:00:00Z","user":"employee_123"}}
    /// </summary>
    public sealed partial class EndUserResponse
    {
        /// <summary>
        /// Example: {"created_at":"2026-09-16T12:00:00Z","is_active":true,"updated_at":"2026-09-16T12:00:00Z","user":"employee_123"}
        /// </summary>
        /// <example>{"created_at":"2026-09-16T12:00:00Z","is_active":true,"updated_at":"2026-09-16T12:00:00Z","user":"employee_123"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.EndUser Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: {"created_at":"2026-09-16T12:00:00Z","is_active":true,"updated_at":"2026-09-16T12:00:00Z","user":"employee_123"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndUserResponse(
            global::OpenRouter.EndUser data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserResponse" /> class.
        /// </summary>
        public EndUserResponse()
        {
        }

    }
}