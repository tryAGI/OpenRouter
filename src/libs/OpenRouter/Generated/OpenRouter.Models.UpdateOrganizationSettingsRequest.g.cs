
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateOrganizationSettingsRequest
    {
        /// <summary>
        /// When true, the signed-in dashboard lists only the models the organization can use. `GET /api/v1/models` called with an API key always returns only the models that key can use, whatever this setting says; anonymous requests receive the public catalog.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateOrganizationSettingsRequest" /> class.
        /// </summary>
        /// <param name="isFilteredModelCatalogEnabled">
        /// When true, the signed-in dashboard lists only the models the organization can use. `GET /api/v1/models` called with an API key always returns only the models that key can use, whatever this setting says; anonymous requests receive the public catalog.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationSettingsRequest(
            bool isFilteredModelCatalogEnabled)
        {
            this.IsFilteredModelCatalogEnabled = isFilteredModelCatalogEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationSettingsRequest" /> class.
        /// </summary>
        public UpdateOrganizationSettingsRequest()
        {
        }

    }
}