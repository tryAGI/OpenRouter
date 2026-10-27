
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The object storage service that hosts the bucket. AWS S3 supports IAM role authentication; the other providers use access keys.
    /// </summary>
    public readonly partial struct ObservabilityS3DestinationConfigProvider : global::System.IEquatable<ObservabilityS3DestinationConfigProvider>
    {
        /// <summary>
        ///
        /// </summary>
        public ObservabilityS3DestinationConfigProvider(string value)
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
        public static ObservabilityS3DestinationConfigProvider Aws { get; } = new("aws");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityS3DestinationConfigProvider CloudflareR2 { get; } = new("cloudflare_r2");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityS3DestinationConfigProvider Gcs { get; } = new("gcs");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityS3DestinationConfigProvider Other { get; } = new("other");
        /// <summary>
        ///
        /// </summary>
        public static ObservabilityS3DestinationConfigProvider FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "aws" => Aws,
                "cloudflare_r2" => CloudflareR2,
                "gcs" => Gcs,
                "other" => Other,
                _ => new ObservabilityS3DestinationConfigProvider(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "aws" => true,
            "cloudflare_r2" => true,
            "gcs" => true,
            "other" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ObservabilityS3DestinationConfigProvider other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityS3DestinationConfigProvider other && Equals(other);
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
        public static bool operator ==(ObservabilityS3DestinationConfigProvider left, ObservabilityS3DestinationConfigProvider right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ObservabilityS3DestinationConfigProvider left, ObservabilityS3DestinationConfigProvider right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityS3DestinationConfigProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityS3DestinationConfigProvider value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityS3DestinationConfigProvider? ToEnum(string value)
        {
            return ObservabilityS3DestinationConfigProvider.FromValue(value);
        }
    }
}