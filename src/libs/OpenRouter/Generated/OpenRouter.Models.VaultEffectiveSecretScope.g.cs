
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Where the delivered secret is stored: `intern` for the intern's own vault, `attached` for a vault attached to the intern, `workspace` for the workspace vault.
    /// </summary>
    public readonly partial struct VaultEffectiveSecretScope : global::System.IEquatable<VaultEffectiveSecretScope>
    {
        /// <summary>
        ///
        /// </summary>
        public VaultEffectiveSecretScope(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `intern` for the intern's own vault, `attached` for a vault attached to the intern, `workspace` for the workspace vault.
        /// </summary>
        public static VaultEffectiveSecretScope Attached { get; } = new("attached");

        /// <summary>
        /// `intern` for the intern's own vault, `attached` for a vault attached to the intern, `workspace` for the workspace vault.
        /// </summary>
        public static VaultEffectiveSecretScope Intern { get; } = new("intern");

        /// <summary>
        /// `intern` for the intern's own vault, `attached` for a vault attached to the intern, `workspace` for the workspace vault.
        /// </summary>
        public static VaultEffectiveSecretScope Workspace { get; } = new("workspace");
        /// <summary>
        ///
        /// </summary>
        public static VaultEffectiveSecretScope FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "attached" => Attached,
                "intern" => Intern,
                "workspace" => Workspace,
                _ => new VaultEffectiveSecretScope(value),
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
        public bool Equals(VaultEffectiveSecretScope other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultEffectiveSecretScope other && Equals(other);
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
        public static bool operator ==(VaultEffectiveSecretScope left, VaultEffectiveSecretScope right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultEffectiveSecretScope left, VaultEffectiveSecretScope right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultEffectiveSecretScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultEffectiveSecretScope value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultEffectiveSecretScope? ToEnum(string value)
        {
            return VaultEffectiveSecretScope.FromValue(value);
        }
    }
}