
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"id":"org_2dHFtVWx2n56w6HkM0000000000","is_filtered_model_catalog_enabled":true}
    /// </summary>
    public sealed partial class OrganizationSettings
    {
        /// <summary>
        /// ID of the organization the settings belong to<br/>
        /// Example: org_2dHFtVWx2n56w6HkM0000000000
        /// </summary>
        /// <example>org_2dHFtVWx2n56w6HkM0000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When true, `GET /api/v1/models` called with one of the organization's API keys returns only the models that key can use (the `/api/v1/models/user` catalog), and the signed-in dashboard shows the same list. Anonymous requests always receive the public catalog.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_filtered_model_catalog_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFilteredModelCatalogEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSettings" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the organization the settings belong to<br/>
        /// Example: org_2dHFtVWx2n56w6HkM0000000000
        /// </param>
        /// <param name="isFilteredModelCatalogEnabled">
        /// When true, `GET /api/v1/models` called with one of the organization's API keys returns only the models that key can use (the `/api/v1/models/user` catalog), and the signed-in dashboard shows the same list. Anonymous requests always receive the public catalog.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationSettings(
            string id,
            bool isFilteredModelCatalogEnabled)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsFilteredModelCatalogEnabled = isFilteredModelCatalogEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSettings" /> class.
        /// </summary>
        public OrganizationSettings()
        {
        }

    }
}