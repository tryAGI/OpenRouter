
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `workspace` applies to every intern of the workspace; `intern` to this intern alone.
    /// </summary>
    public readonly partial struct VaultRoutingTableGoogleAccountScope : global::System.IEquatable<VaultRoutingTableGoogleAccountScope>
    {
        /// <summary>
        ///
        /// </summary>
        public VaultRoutingTableGoogleAccountScope(string value)
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
        public static VaultRoutingTableGoogleAccountScope Intern { get; } = new("intern");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableGoogleAccountScope Workspace { get; } = new("workspace");
        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableGoogleAccountScope FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "intern" => Intern,
                "workspace" => Workspace,
                _ => new VaultRoutingTableGoogleAccountScope(value),
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
        public bool Equals(VaultRoutingTableGoogleAccountScope other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultRoutingTableGoogleAccountScope other && Equals(other);
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
        public static bool operator ==(VaultRoutingTableGoogleAccountScope left, VaultRoutingTableGoogleAccountScope right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultRoutingTableGoogleAccountScope left, VaultRoutingTableGoogleAccountScope right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultRoutingTableGoogleAccountScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultRoutingTableGoogleAccountScope value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultRoutingTableGoogleAccountScope? ToEnum(string value)
        {
            return VaultRoutingTableGoogleAccountScope.FromValue(value);
        }
    }
}