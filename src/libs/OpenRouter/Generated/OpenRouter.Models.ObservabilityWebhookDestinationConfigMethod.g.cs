
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Default Value: POST
    /// </summary>
    public readonly partial struct ObservabilityWebhookDestinationConfigMethod : global::System.IEquatable<ObservabilityWebhookDestinationConfigMethod>
    {
        /// <summary>
        ///
        /// </summary>
        public ObservabilityWebhookDestinationConfigMethod(string value)
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
        public static ObservabilityWebhookDestinationConfigMethod Post { get; } = new("POST");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityWebhookDestinationConfigMethod Put { get; } = new("PUT");
        /// <summary>
        ///
        /// </summary>
        public static ObservabilityWebhookDestinationConfigMethod FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "POST" => Post,
                "PUT" => Put,
                _ => new ObservabilityWebhookDestinationConfigMethod(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "POST" => true,
            "PUT" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ObservabilityWebhookDestinationConfigMethod other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityWebhookDestinationConfigMethod other && Equals(other);
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
        public static bool operator ==(ObservabilityWebhookDestinationConfigMethod left, ObservabilityWebhookDestinationConfigMethod right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ObservabilityWebhookDestinationConfigMethod left, ObservabilityWebhookDestinationConfigMethod right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityWebhookDestinationConfigMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityWebhookDestinationConfigMethod value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityWebhookDestinationConfigMethod? ToEnum(string value)
        {
            return ObservabilityWebhookDestinationConfigMethod.FromValue(value);
        }
    }
}