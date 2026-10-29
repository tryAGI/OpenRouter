
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `workspace` applies to every intern of the workspace; `intern` to this intern alone.
    /// </summary>
    public readonly partial struct VaultRoutingTableGithubTokenScope : global::System.IEquatable<VaultRoutingTableGithubTokenScope>
    {
        /// <summary>
        ///
        /// </summary>
        public VaultRoutingTableGithubTokenScope(string value)
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
        public static VaultRoutingTableGithubTokenScope Intern { get; } = new("intern");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableGithubTokenScope Workspace { get; } = new("workspace");
        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableGithubTokenScope FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "intern" => Intern,
                "workspace" => Workspace,
                _ => new VaultRoutingTableGithubTokenScope(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "intern" => true,
            "workspace" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(VaultRoutingTableGithubTokenScope other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultRoutingTableGithubTokenScope other && Equals(other);
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
        public static bool operator ==(VaultRoutingTableGithubTokenScope left, VaultRoutingTableGithubTokenScope right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultRoutingTableGithubTokenScope left, VaultRoutingTableGithubTokenScope right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultRoutingTableGithubTokenScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultRoutingTableGithubTokenScope value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultRoutingTableGithubTokenScope? ToEnum(string value)
        {
            return VaultRoutingTableGithubTokenScope.FromValue(value);
        }
    }
}