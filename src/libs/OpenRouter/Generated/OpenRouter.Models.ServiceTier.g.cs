
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: default
    /// </summary>
    public readonly partial struct ServiceTier : global::System.IEquatable<ServiceTier>
    {
        /// <summary>
        ///
        /// </summary>
        public ServiceTier(string value)
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
        public static ServiceTier Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ServiceTier Default { get; } = new("default");

        /// <summary>
        ///
        /// </summary>
        public static ServiceTier Flex { get; } = new("flex");

        /// <summary>
        ///
        /// </summary>
        public static ServiceTier Priority { get; } = new("priority");

        /// <summary>
        ///
        /// </summary>
        public static ServiceTier Scale { get; } = new("scale");

        /// <summary>
        ///
        /// </summary>
        public static ServiceTier Ultrafast { get; } = new("ultrafast");
        /// <summary>
        ///
        /// </summary>
        public static ServiceTier FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "default" => Default,
                "flex" => Flex,
                "priority" => Priority,
                "scale" => Scale,
                "ultrafast" => Ultrafast,
                _ => new ServiceTier(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "default" => true,
            "flex" => true,
            "priority" => true,
            "scale" => true,
            "ultrafast" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ServiceTier other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServiceTier other && Equals(other);
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
        public static bool operator ==(ServiceTier left, ServiceTier right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServiceTier left, ServiceTier right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTier value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTier? ToEnum(string value)
        {
            return ServiceTier.FromValue(value);
        }
    }
}