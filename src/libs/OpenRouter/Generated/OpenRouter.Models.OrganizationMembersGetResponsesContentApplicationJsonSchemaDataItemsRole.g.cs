
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Role of the member in the organization
    /// </summary>
    public enum OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole
    {
        /// <summary>
        /// 
        /// </summary>
        Org_admin,
        /// <summary>
        /// 
        /// </summary>
        Org_member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole value)
        {
            return value switch
            {
                OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole.Org_admin => "org:admin",
                OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole.Org_member => "org:member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole? ToEnum(string value)
        {
            return value switch
            {
                "org:admin" => OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole.Org_admin,
                "org:member" => OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole.Org_member,
                _ => null,
            };
        }
    }
}