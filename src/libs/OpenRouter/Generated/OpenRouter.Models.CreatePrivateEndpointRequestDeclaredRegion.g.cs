
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Attest where this deployment processes data.<br/>
    /// Example: us
    /// </summary>
    public readonly partial struct CreatePrivateEndpointRequestDeclaredRegion : global::System.IEquatable<CreatePrivateEndpointRequestDeclaredRegion>
    {
        /// <summary>
        ///
        /// </summary>
        public CreatePrivateEndpointRequestDeclaredRegion(string value)
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
        public static CreatePrivateEndpointRequestDeclaredRegion Europe { get; } = new("europe");

        /// <summary>
        ///
        /// </summary>
        public static CreatePrivateEndpointRequestDeclaredRegion Global { get; } = new("global");

        /// <summary>
        ///
        /// </summary>
        public static CreatePrivateEndpointRequestDeclaredRegion Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static CreatePrivateEndpointRequestDeclaredRegion FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "europe" => Europe,
                "global" => Global,
                "us" => Us,
                _ => new CreatePrivateEndpointRequestDeclaredRegion(value),
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
        public bool Equals(CreatePrivateEndpointRequestDeclaredRegion other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreatePrivateEndpointRequestDeclaredRegion other && Equals(other);
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
        public static bool operator ==(CreatePrivateEndpointRequestDeclaredRegion left, CreatePrivateEndpointRequestDeclaredRegion right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreatePrivateEndpointRequestDeclaredRegion left, CreatePrivateEndpointRequestDeclaredRegion right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePrivateEndpointRequestDeclaredRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePrivateEndpointRequestDeclaredRegion value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePrivateEndpointRequestDeclaredRegion? ToEnum(string value)
        {
            return CreatePrivateEndpointRequestDeclaredRegion.FromValue(value);
        }
    }
}