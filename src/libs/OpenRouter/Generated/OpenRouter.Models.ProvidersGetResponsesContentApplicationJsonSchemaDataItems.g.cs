
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProvidersGetResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// Display name of the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL-friendly identifier for the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// URL to the provider's privacy policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_policy_url")]
        public string? PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// URL to the provider's terms of service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_of_service_url")]
        public string? TermsOfServiceUrl { get; set; }

        /// <summary>
        /// URL to the provider's status page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_page_url")]
        public string? StatusPageUrl { get; set; }

        /// <summary>
        /// ISO 3166-1 Alpha-2 country code of the provider headquarters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headquarters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?, object>? Headquarters { get; set; }

        /// <summary>
        /// ISO 3166-1 Alpha-2 country codes of the provider datacenter locations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datacenters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems>? Datacenters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the provider
        /// </param>
        /// <param name="slug">
        /// URL-friendly identifier for the provider
        /// </param>
        /// <param name="privacyPolicyUrl">
        /// URL to the provider's privacy policy
        /// </param>
        /// <param name="termsOfServiceUrl">
        /// URL to the provider's terms of service
        /// </param>
        /// <param name="statusPageUrl">
        /// URL to the provider's status page
        /// </param>
        /// <param name="headquarters">
        /// ISO 3166-1 Alpha-2 country code of the provider headquarters
        /// </param>
        /// <param name="datacenters">
        /// ISO 3166-1 Alpha-2 country codes of the provider datacenter locations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProvidersGetResponsesContentApplicationJsonSchemaDataItems(
            string name,
            string slug,
            string? privacyPolicyUrl,
            string? termsOfServiceUrl,
            string? statusPageUrl,
            global::OpenRouter.OneOf<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?, object>? headquarters,
            global::System.Collections.Generic.IList<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems>? datacenters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.PrivacyPolicyUrl = privacyPolicyUrl;
            this.TermsOfServiceUrl = termsOfServiceUrl;
            this.StatusPageUrl = statusPageUrl;
            this.Headquarters = headquarters;
            this.Datacenters = datacenters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public ProvidersGetResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}