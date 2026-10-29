
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct VaultRoutingTableGithubAppInstallationAccountType : global::System.IEquatable<VaultRoutingTableGithubAppInstallationAccountType>
    {
        /// <summary>
        ///
        /// </summary>
        public VaultRoutingTableGithubAppInstallationAccountType(string value)
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
        public static VaultRoutingTableGithubAppInstallationAccountType Organization { get; } = new("organization");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableGithubAppInstallationAccountType User { get; } = new("user");
        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableGithubAppInstallationAccountType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "organization" => Organization,
                "user" => User,
                _ => new VaultRoutingTableGithubAppInstallationAccountType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "organization" => true,
            "user" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(VaultRoutingTableGithubAppInstallationAccountType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultRoutingTableGithubAppInstallationAccountType other && Equals(other);
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
        public static bool operator ==(VaultRoutingTableGithubAppInstallationAccountType left, VaultRoutingTableGithubAppInstallationAccountType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultRoutingTableGithubAppInstallationAccountType left, VaultRoutingTableGithubAppInstallationAccountType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultRoutingTableGithubAppInstallationAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultRoutingTableGithubAppInstallationAccountType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultRoutingTableGithubAppInstallationAccountType? ToEnum(string value)
        {
            return VaultRoutingTableGithubAppInstallationAccountType.FromValue(value);
        }
    }
}