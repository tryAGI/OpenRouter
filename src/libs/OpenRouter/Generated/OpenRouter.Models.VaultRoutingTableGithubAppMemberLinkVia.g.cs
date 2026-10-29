
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// How the vault picks this link for the App, by the same selection egress uses.
    /// </summary>
    public readonly partial struct VaultRoutingTableGithubAppMemberLinkVia : global::System.IEquatable<VaultRoutingTableGithubAppMemberLinkVia>
    {
        /// <summary>
        ///
        /// </summary>
        public VaultRoutingTableGithubAppMemberLinkVia(string value)
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
        public static VaultRoutingTableGithubAppMemberLinkVia AnyLink { get; } = new("any_link");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableGithubAppMemberLinkVia AppLink { get; } = new("app_link");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableGithubAppMemberLinkVia Token { get; } = new("token");
        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableGithubAppMemberLinkVia FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "any_link" => AnyLink,
                "app_link" => AppLink,
                "token" => Token,
                _ => new VaultRoutingTableGithubAppMemberLinkVia(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "any_link" => true,
            "app_link" => true,
            "token" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(VaultRoutingTableGithubAppMemberLinkVia other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultRoutingTableGithubAppMemberLinkVia other && Equals(other);
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
        public static bool operator ==(VaultRoutingTableGithubAppMemberLinkVia left, VaultRoutingTableGithubAppMemberLinkVia right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultRoutingTableGithubAppMemberLinkVia left, VaultRoutingTableGithubAppMemberLinkVia right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultRoutingTableGithubAppMemberLinkViaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultRoutingTableGithubAppMemberLinkVia value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultRoutingTableGithubAppMemberLinkVia? ToEnum(string value)
        {
            return VaultRoutingTableGithubAppMemberLinkVia.FromValue(value);
        }
    }
}