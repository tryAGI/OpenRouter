
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetScimGroupMappingResponse
    {
        /// <summary>
        /// Example: {"created_at":"2025-08-24T10:30:00.000Z","id":"770e8400-e29b-41d4-a716-446655440000","organization_id":"org_123456","role":"member","scim_group_id":"550e8400-e29b-41d4-a716-446655440000","updated_at":"2025-08-24T10:30:00.000Z","workspace_id":"660e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
        /// <example>{"created_at":"2025-08-24T10:30:00.000Z","id":"770e8400-e29b-41d4-a716-446655440000","organization_id":"org_123456","role":"member","scim_group_id":"550e8400-e29b-41d4-a716-446655440000","updated_at":"2025-08-24T10:30:00.000Z","workspace_id":"660e8400-e29b-41d4-a716-446655440000"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ScimGroupMapping Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScimGroupMappingResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: {"created_at":"2025-08-24T10:30:00.000Z","id":"770e8400-e29b-41d4-a716-446655440000","organization_id":"org_123456","role":"member","scim_group_id":"550e8400-e29b-41d4-a716-446655440000","updated_at":"2025-08-24T10:30:00.000Z","workspace_id":"660e8400-e29b-41d4-a716-446655440000"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScimGroupMappingResponse(
            global::OpenRouter.ScimGroupMapping data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScimGroupMappingResponse" /> class.
        /// </summary>
        public GetScimGroupMappingResponse()
        {
        }

    }
}