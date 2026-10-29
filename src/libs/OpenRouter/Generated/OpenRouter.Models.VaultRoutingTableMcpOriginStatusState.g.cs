
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct VaultRoutingTableMcpOriginStatusState : global::System.IEquatable<VaultRoutingTableMcpOriginStatusState>
    {
        /// <summary>
        ///
        /// </summary>
        public VaultRoutingTableMcpOriginStatusState(string value)
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
        public static VaultRoutingTableMcpOriginStatusState Failing { get; } = new("failing");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableMcpOriginStatusState NoCredential { get; } = new("no_credential");

        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableMcpOriginStatusState Usable { get; } = new("usable");
        /// <summary>
        ///
        /// </summary>
        public static VaultRoutingTableMcpOriginStatusState FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "failing" => Failing,
                "no_credential" => NoCredential,
                "usable" => Usable,
                _ => new VaultRoutingTableMcpOriginStatusState(value),
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
        public bool Equals(VaultRoutingTableMcpOriginStatusState other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VaultRoutingTableMcpOriginStatusState other && Equals(other);
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
        public static bool operator ==(VaultRoutingTableMcpOriginStatusState left, VaultRoutingTableMcpOriginStatusState right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VaultRoutingTableMcpOriginStatusState left, VaultRoutingTableMcpOriginStatusState right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultRoutingTableMcpOriginStatusStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultRoutingTableMcpOriginStatusState value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultRoutingTableMcpOriginStatusState? ToEnum(string value)
        {
            return VaultRoutingTableMcpOriginStatusState.FromValue(value);
        }
    }
}