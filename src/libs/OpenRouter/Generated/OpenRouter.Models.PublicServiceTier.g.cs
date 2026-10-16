
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The service tier this endpoint sells, or null for a standard endpoint. The same value whether the provider selects the tier with a request parameter or with a dedicated model id. Always the canonical tier: priority covers the fast request alias and the turbo, highspeed, and prime provider model-id spellings, none of which this field reports.<br/>
    /// Example: priority
    /// </summary>
    public readonly partial struct PublicServiceTier : global::System.IEquatable<PublicServiceTier>
    {
        /// <summary>
        ///
        /// </summary>
        public PublicServiceTier(string value)
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
        public static PublicServiceTier Flex { get; } = new("flex");

        /// <summary>
        /// priority covers the fast request alias and the turbo, highspeed, and prime provider model-id spellings, none of which this field reports.
        /// </summary>
        public static PublicServiceTier Priority { get; } = new("priority");

        /// <summary>
        ///
        /// </summary>
        public static PublicServiceTier Ultrafast { get; } = new("ultrafast");
        /// <summary>
        ///
        /// </summary>
        public static PublicServiceTier FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "flex" => Flex,
                "priority" => Priority,
                "ultrafast" => Ultrafast,
                _ => new PublicServiceTier(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
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
        public bool Equals(PublicServiceTier other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PublicServiceTier other && Equals(other);
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
        public static bool operator ==(PublicServiceTier left, PublicServiceTier right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PublicServiceTier left, PublicServiceTier right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicServiceTier value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicServiceTier? ToEnum(string value)
        {
            return PublicServiceTier.FromValue(value);
        }
    }
}