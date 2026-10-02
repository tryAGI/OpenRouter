
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Where you attest this deployment processes data. `global` means not regional; `null` means undeclared.<br/>
    /// Example: us
    /// </summary>
    public readonly partial struct PrivateEndpointDeclaredRegion : global::System.IEquatable<PrivateEndpointDeclaredRegion>
    {
        /// <summary>
        ///
        /// </summary>
        public PrivateEndpointDeclaredRegion(string value)
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
        public static PrivateEndpointDeclaredRegion Europe { get; } = new("europe");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointDeclaredRegion Global { get; } = new("global");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointDeclaredRegion Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointDeclaredRegion FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "europe" => Europe,
                "global" => Global,
                "us" => Us,
                _ => new PrivateEndpointDeclaredRegion(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "europe" => true,
            "global" => true,
            "us" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(PrivateEndpointDeclaredRegion other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrivateEndpointDeclaredRegion other && Equals(other);
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
        public static bool operator ==(PrivateEndpointDeclaredRegion left, PrivateEndpointDeclaredRegion right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PrivateEndpointDeclaredRegion left, PrivateEndpointDeclaredRegion right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateEndpointDeclaredRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateEndpointDeclaredRegion value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateEndpointDeclaredRegion? ToEnum(string value)
        {
            return PrivateEndpointDeclaredRegion.FromValue(value);
        }
    }
}