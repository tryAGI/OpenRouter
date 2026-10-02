
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Lifecycle state. `draft` endpoints are not routable until validated and activated; `disabled` endpoints are activated but temporarily not routable.<br/>
    /// Example: active
    /// </summary>
    public readonly partial struct PrivateEndpointStatus : global::System.IEquatable<PrivateEndpointStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public PrivateEndpointStatus(string value)
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
        public static PrivateEndpointStatus Active { get; } = new("active");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointStatus Disabled { get; } = new("disabled");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointStatus Draft { get; } = new("draft");
        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "active" => Active,
                "disabled" => Disabled,
                "draft" => Draft,
                _ => new PrivateEndpointStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "active" => true,
            "disabled" => true,
            "draft" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(PrivateEndpointStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrivateEndpointStatus other && Equals(other);
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
        public static bool operator ==(PrivateEndpointStatus left, PrivateEndpointStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PrivateEndpointStatus left, PrivateEndpointStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateEndpointStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateEndpointStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateEndpointStatus? ToEnum(string value)
        {
            return PrivateEndpointStatus.FromValue(value);
        }
    }
}