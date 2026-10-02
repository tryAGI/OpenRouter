
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"datacenters":["US","IE"],"headquarters":"US","name":"OpenAI","privacy_policy_url":"https://openai.com/privacy","slug":"openai","status_page_url":"https://status.openai.com","terms_of_service_url":"https://openai.com/terms"}
    /// </summary>
    public sealed partial class ListProvidersResponseDataItem
    {
        /// <summary>
        /// ISO 3166-1 Alpha-2 country codes of the provider datacenter locations<br/>
        /// Example: [US, IE]
        /// </summary>
        /// <example>[US, IE]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("datacenters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ListProvidersResponseDataItemDatacenter>? Datacenters { get; set; }

        /// <summary>
        /// ISO 3166-1 Alpha-2 country code of the provider headquarters<br/>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headquarters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ListProvidersResponseDataItemHeadquartersJsonConverter))]
        public global::OpenRouter.ListProvidersResponseDataItemHeadquarters? Headquarters { get; set; }

        /// <summary>
        /// Display name of the provider<br/>
        /// Example: OpenAI
        /// </summary>
        /// <example>OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL to the provider's privacy policy<br/>
        /// Example: https://openai.com/privacy
        /// </summary>
        /// <example>https://openai.com/privacy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_policy_url")]
        public string? PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// URL-friendly identifier for the provider<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// URL to the provider's status page<br/>
        /// Example: https://status.openai.com
        /// </summary>
        /// <example>https://status.openai.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_page_url")]
        public string? StatusPageUrl { get; set; }

        /// <summary>
        /// URL to the provider's terms of service<br/>
        /// Example: https://openai.com/terms
        /// </summary>
        /// <example>https://openai.com/terms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_of_service_url")]
        public string? TermsOfServiceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProvidersResponseDataItem" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the provider<br/>
        /// Example: OpenAI
        /// </param>
        /// <param name="slug">
        /// URL-friendly identifier for the provider<br/>
        /// Example: openai
        /// </param>
        /// <param name="datacenters">
        /// ISO 3166-1 Alpha-2 country codes of the provider datacenter locations<br/>
        /// Example: [US, IE]
        /// </param>
        /// <param name="headquarters">
        /// ISO 3166-1 Alpha-2 country code of the provider headquarters<br/>
        /// Example: US
        /// </param>
        /// <param name="privacyPolicyUrl">
        /// URL to the provider's privacy policy<br/>
        /// Example: https://openai.com/privacy
        /// </param>
        /// <param name="statusPageUrl">
        /// URL to the provider's status page<br/>
        /// Example: https://status.openai.com
        /// </param>
        /// <param name="termsOfServiceUrl">
        /// URL to the provider's terms of service<br/>
        /// Example: https://openai.com/terms
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProvidersResponseDataItem(
            string name,
            string slug,
            global::System.Collections.Generic.IList<global::OpenRouter.ListProvidersResponseDataItemDatacenter>? datacenters,
            global::OpenRouter.ListProvidersResponseDataItemHeadquarters? headquarters,
            string? privacyPolicyUrl,
            string? statusPageUrl,
            string? termsOfServiceUrl)
        {
            this.Datacenters = datacenters;
            this.Headquarters = headquarters;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PrivacyPolicyUrl = privacyPolicyUrl;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.StatusPageUrl = statusPageUrl;
            this.TermsOfServiceUrl = termsOfServiceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProvidersResponseDataItem" /> class.
        /// </summary>
        public ListProvidersResponseDataItem()
        {
        }

    }
}