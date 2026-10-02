
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationSettingsResponse
    {
        /// <summary>
        /// Example: {"id":"org_2dHFtVWx2n56w6HkM0000000000","is_filtered_model_catalog_enabled":true}
        /// </summary>
        /// <example>{"id":"org_2dHFtVWx2n56w6HkM0000000000","is_filtered_model_catalog_enabled":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OrganizationSettings Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationSettingsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: {"id":"org_2dHFtVWx2n56w6HkM0000000000","is_filtered_model_catalog_enabled":true}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationSettingsResponse(
            global::OpenRouter.OrganizationSettings data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationSettingsResponse" /> class.
        /// </summary>
        public GetOrganizationSettingsResponse()
        {
        }

    }
}