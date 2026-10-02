
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Attest where this deployment processes data.<br/>
    /// Example: us
    /// </summary>
    public readonly partial struct UpdatePrivateEndpointRequestDeclaredRegion : global::System.IEquatable<UpdatePrivateEndpointRequestDeclaredRegion>
    {
        /// <summary>
        ///
        /// </summary>
        public UpdatePrivateEndpointRequestDeclaredRegion(string value)
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
        public static UpdatePrivateEndpointRequestDeclaredRegion Europe { get; } = new("europe");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointRequestDeclaredRegion Global { get; } = new("global");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointRequestDeclaredRegion Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointRequestDeclaredRegion FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "europe" => Europe,
                "global" => Global,
                "us" => Us,
                _ => new UpdatePrivateEndpointRequestDeclaredRegion(value),
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
        public bool Equals(UpdatePrivateEndpointRequestDeclaredRegion other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdatePrivateEndpointRequestDeclaredRegion other && Equals(other);
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
        public static bool operator ==(UpdatePrivateEndpointRequestDeclaredRegion left, UpdatePrivateEndpointRequestDeclaredRegion right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdatePrivateEndpointRequestDeclaredRegion left, UpdatePrivateEndpointRequestDeclaredRegion right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePrivateEndpointRequestDeclaredRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePrivateEndpointRequestDeclaredRegion value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePrivateEndpointRequestDeclaredRegion? ToEnum(string value)
        {
            return UpdatePrivateEndpointRequestDeclaredRegion.FromValue(value);
        }
    }
}