
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct VaultRoutingTableCustomOriginStatusState : global::System.IEquatable<VaultRoutingTableCustomOriginStatusState>
    {
        /// <summary>
        ///
        /// </summary>
        public VaultRoutingTableCustomOriginStatusState(string value)
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
        public static VaultRoutingTableCustomOriginStatusState Failing { get; } = new("failing");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableCustomOriginStatusState NoCredential { get; } = new("no_credential");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableCustomOriginStatusState Usable { get; } = new("usable");
        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableCustomOriginStatusState FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "failing" => Failing,
                "no_credential" => NoCredential,
                "usable" => Usable,
                _ => new VaultRoutingTableCustomOriginStatusState(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "failing" => true,
            "no_credential" => true,
            "usable" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(VaultRoutingTableCustomOriginStatusState other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultRoutingTableCustomOriginStatusState other && Equals(other);
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
        public static bool operator ==(VaultRoutingTableCustomOriginStatusState left, VaultRoutingTableCustomOriginStatusState right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultRoutingTableCustomOriginStatusState left, VaultRoutingTableCustomOriginStatusState right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultRoutingTableCustomOriginStatusStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultRoutingTableCustomOriginStatusState value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultRoutingTableCustomOriginStatusState? ToEnum(string value)
        {
            return VaultRoutingTableCustomOriginStatusState.FromValue(value);
        }
    }
}