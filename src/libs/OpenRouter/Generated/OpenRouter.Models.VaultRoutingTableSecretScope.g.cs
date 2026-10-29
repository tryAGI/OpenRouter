
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct VaultRoutingTableSecretScope : global::System.IEquatable<VaultRoutingTableSecretScope>
    {
        /// <summary>
        ///
        /// </summary>
        public VaultRoutingTableSecretScope(string value)
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
        public static VaultRoutingTableSecretScope Attached { get; } = new("attached");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableSecretScope Intern { get; } = new("intern");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableSecretScope Workspace { get; } = new("workspace");
        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableSecretScope FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "attached" => Attached,
                "intern" => Intern,
                "workspace" => Workspace,
                _ => new VaultRoutingTableSecretScope(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "attached" => true,
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
        public bool Equals(VaultRoutingTableSecretScope other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultRoutingTableSecretScope other && Equals(other);
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
        public static bool operator ==(VaultRoutingTableSecretScope left, VaultRoutingTableSecretScope right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultRoutingTableSecretScope left, VaultRoutingTableSecretScope right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultRoutingTableSecretScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultRoutingTableSecretScope value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultRoutingTableSecretScope? ToEnum(string value)
        {
            return VaultRoutingTableSecretScope.FromValue(value);
        }
    }
}