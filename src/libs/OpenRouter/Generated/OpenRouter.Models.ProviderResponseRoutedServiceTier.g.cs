
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The service tier this request was routed to (e.g. flex, priority). The tier actually applied and billed is determined by the provider response and may differ.<br/>
    /// Example: priority
    /// </summary>
    public readonly partial struct ProviderResponseRoutedServiceTier : global::System.IEquatable<ProviderResponseRoutedServiceTier>
    {
        /// <summary>
        ///
        /// </summary>
        public ProviderResponseRoutedServiceTier(string value)
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
        public static ProviderResponseRoutedServiceTier Flex { get; } = new("flex");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseRoutedServiceTier Priority { get; } = new("priority");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseRoutedServiceTier Ultrafast { get; } = new("ultrafast");
        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseRoutedServiceTier FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "flex" => Flex,
                "priority" => Priority,
                "ultrafast" => Ultrafast,
                _ => new ProviderResponseRoutedServiceTier(value),
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
        public bool Equals(ProviderResponseRoutedServiceTier other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderResponseRoutedServiceTier other && Equals(other);
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
        public static bool operator ==(ProviderResponseRoutedServiceTier left, ProviderResponseRoutedServiceTier right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderResponseRoutedServiceTier left, ProviderResponseRoutedServiceTier right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResponseRoutedServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResponseRoutedServiceTier value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResponseRoutedServiceTier? ToEnum(string value)
        {
            return ProviderResponseRoutedServiceTier.FromValue(value);
        }
    }
}