
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// What egress uses instead of this installation for a request to its account: an earlier installation on the same account, or a token pinned to the account. Null when this installation answers.
    /// </summary>
    public readonly partial struct VaultRoutingTableGithubAppInstallationShadowedBy : global::System.IEquatable<VaultRoutingTableGithubAppInstallationShadowedBy>
    {
        /// <summary>
        ///
        /// </summary>
        public VaultRoutingTableGithubAppInstallationShadowedBy(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// an earlier installation on the same account, or a token pinned to the account. Null when this installation answers.
        /// </summary>
        public static VaultRoutingTableGithubAppInstallationShadowedBy Installation { get; } = new("installation");

        /// <summary>
        /// an earlier installation on the same account, or a token pinned to the account. Null when this installation answers.
        /// </summary>
        public static VaultRoutingTableGithubAppInstallationShadowedBy Token { get; } = new("token");
        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableGithubAppInstallationShadowedBy FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "installation" => Installation,
                "token" => Token,
                _ => new VaultRoutingTableGithubAppInstallationShadowedBy(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "installation" => true,
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
        public bool Equals(VaultRoutingTableGithubAppInstallationShadowedBy other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultRoutingTableGithubAppInstallationShadowedBy other && Equals(other);
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
        public static bool operator ==(VaultRoutingTableGithubAppInstallationShadowedBy left, VaultRoutingTableGithubAppInstallationShadowedBy right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultRoutingTableGithubAppInstallationShadowedBy left, VaultRoutingTableGithubAppInstallationShadowedBy right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultRoutingTableGithubAppInstallationShadowedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultRoutingTableGithubAppInstallationShadowedBy value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultRoutingTableGithubAppInstallationShadowedBy? ToEnum(string value)
        {
            return VaultRoutingTableGithubAppInstallationShadowedBy.FromValue(value);
        }
    }
}