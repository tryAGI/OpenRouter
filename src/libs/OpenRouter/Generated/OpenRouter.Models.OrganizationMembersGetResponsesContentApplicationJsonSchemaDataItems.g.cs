
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// User ID of the organization member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// First name of the member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Email address of the member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Role of the member in the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="id">
        /// User ID of the organization member
        /// </param>
        /// <param name="email">
        /// Email address of the member
        /// </param>
        /// <param name="role">
        /// Role of the member in the organization
        /// </param>
        /// <param name="firstName">
        /// First name of the member
        /// </param>
        /// <param name="lastName">
        /// Last name of the member
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems(
            string id,
            string email,
            global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole role,
            string? firstName,
            string? lastName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}