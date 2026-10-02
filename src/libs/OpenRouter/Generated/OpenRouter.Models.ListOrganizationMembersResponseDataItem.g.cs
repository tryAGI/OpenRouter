
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListOrganizationMembersResponseDataItem
    {
        /// <summary>
        /// Email address of the member<br/>
        /// Example: jane.doe@example.com
        /// </summary>
        /// <example>jane.doe@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// First name of the member<br/>
        /// Example: Jane
        /// </summary>
        /// <example>Jane</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// User ID of the organization member<br/>
        /// Example: user_2dHFtVWx2n56w6HkM0000000000
        /// </summary>
        /// <example>user_2dHFtVWx2n56w6HkM0000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Last name of the member<br/>
        /// Example: Doe
        /// </summary>
        /// <example>Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Role of the member in the organization<br/>
        /// Example: org:member
        /// </summary>
        /// <example>org:member</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ListOrganizationMembersResponseDataItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ListOrganizationMembersResponseDataItemRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationMembersResponseDataItem" /> class.
        /// </summary>
        /// <param name="email">
        /// Email address of the member<br/>
        /// Example: jane.doe@example.com
        /// </param>
        /// <param name="id">
        /// User ID of the organization member<br/>
        /// Example: user_2dHFtVWx2n56w6HkM0000000000
        /// </param>
        /// <param name="role">
        /// Role of the member in the organization<br/>
        /// Example: org:member
        /// </param>
        /// <param name="firstName">
        /// First name of the member<br/>
        /// Example: Jane
        /// </param>
        /// <param name="lastName">
        /// Last name of the member<br/>
        /// Example: Doe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOrganizationMembersResponseDataItem(
            string email,
            string id,
            global::OpenRouter.ListOrganizationMembersResponseDataItemRole role,
            string? firstName,
            string? lastName)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FirstName = firstName;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastName = lastName;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationMembersResponseDataItem" /> class.
        /// </summary>
        public ListOrganizationMembersResponseDataItem()
        {
        }

    }
}