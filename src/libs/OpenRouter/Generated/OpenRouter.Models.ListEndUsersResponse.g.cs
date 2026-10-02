
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"created_at":"2026-09-16T12:00:00Z","is_active":true,"updated_at":"2026-09-16T12:00:00Z","user":"employee_123"}],"total_count":1}
    /// </summary>
    public sealed partial class ListEndUsersResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.EndUser> Data { get; set; }

        /// <summary>
        /// Number of registrations matching the filters before pagination.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndUsersResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="totalCount">
        /// Number of registrations matching the filters before pagination.<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEndUsersResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.EndUser> data,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndUsersResponse" /> class.
        /// </summary>
        public ListEndUsersResponse()
        {
        }

    }
}