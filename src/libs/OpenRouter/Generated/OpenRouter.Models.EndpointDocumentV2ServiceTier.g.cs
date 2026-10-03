
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EndpointDocumentV2ServiceTier : global::System.IEquatable<EndpointDocumentV2ServiceTier>
    {
        /// <summary>
        ///
        /// </summary>
        public EndpointDocumentV2ServiceTier(string value)
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
        public static EndpointDocumentV2ServiceTier Fast { get; } = new("fast");

        /// <summary>
        ///
        /// </summary>
        public static EndpointDocumentV2ServiceTier Flex { get; } = new("flex");

        /// <summary>
        ///
        /// </summary>
        public static EndpointDocumentV2ServiceTier Priority { get; } = new("priority");

        /// <summary>
        ///
        /// </summary>
        public static EndpointDocumentV2ServiceTier Ultrafast { get; } = new("ultrafast");
        /// <summary>
        ///
        /// </summary>
        public static EndpointDocumentV2ServiceTier FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "fast" => Fast,
                "flex" => Flex,
                "priority" => Priority,
                "ultrafast" => Ultrafast,
                _ => new EndpointDocumentV2ServiceTier(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "fast" => true,
            "flex" => true,
            "priority" => true,
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
        public bool Equals(EndpointDocumentV2ServiceTier other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EndpointDocumentV2ServiceTier other && Equals(other);
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
        public static bool operator ==(EndpointDocumentV2ServiceTier left, EndpointDocumentV2ServiceTier right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EndpointDocumentV2ServiceTier left, EndpointDocumentV2ServiceTier right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndpointDocumentV2ServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndpointDocumentV2ServiceTier value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndpointDocumentV2ServiceTier? ToEnum(string value)
        {
            return EndpointDocumentV2ServiceTier.FromValue(value);
        }
    }
}