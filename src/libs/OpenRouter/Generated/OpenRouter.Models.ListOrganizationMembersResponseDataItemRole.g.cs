
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Role of the member in the organization<br/>
    /// Example: org:member
    /// </summary>
    public readonly partial struct ListOrganizationMembersResponseDataItemRole : global::System.IEquatable<ListOrganizationMembersResponseDataItemRole>
    {
        /// <summary>
        ///
        /// </summary>
        public ListOrganizationMembersResponseDataItemRole(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static ListOrganizationMembersResponseDataItemRole Org_admin { get; } = new("org:admin");

        /// <summary>
        ///
        /// </summary>
        public static ListOrganizationMembersResponseDataItemRole Org_member { get; } = new("org:member");
        /// <summary>
        ///
        /// </summary>
        public static ListOrganizationMembersResponseDataItemRole FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "org:admin" => Org_admin,
                "org:member" => Org_member,
                _ => new ListOrganizationMembersResponseDataItemRole(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "org:admin" => true,
            "org:member" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ListOrganizationMembersResponseDataItemRole other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOrganizationMembersResponseDataItemRole other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ListOrganizationMembersResponseDataItemRole left, ListOrganizationMembersResponseDataItemRole right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListOrganizationMembersResponseDataItemRole left, ListOrganizationMembersResponseDataItemRole right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListOrganizationMembersResponseDataItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListOrganizationMembersResponseDataItemRole value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListOrganizationMembersResponseDataItemRole? ToEnum(string value)
        {
            return ListOrganizationMembersResponseDataItemRole.FromValue(value);
        }
    }
}