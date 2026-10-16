
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// IAM role: OpenRouter assumes a role in your AWS account with short-lived STS credentials, so you don't share long-lived keys.<br/>
    /// Default Value: access_keys
    /// </summary>
    public readonly partial struct ObservabilityS3DestinationConfigAuthMode : global::System.IEquatable<ObservabilityS3DestinationConfigAuthMode>
    {
        /// <summary>
        ///
        /// </summary>
        public ObservabilityS3DestinationConfigAuthMode(string value)
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
        public static ObservabilityS3DestinationConfigAuthMode AccessKeys { get; } = new("access_keys");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityS3DestinationConfigAuthMode IamRole { get; } = new("iam_role");
        /// <summary>
        ///
        /// </summary>
        public static ObservabilityS3DestinationConfigAuthMode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "access_keys" => AccessKeys,
                "iam_role" => IamRole,
                _ => new ObservabilityS3DestinationConfigAuthMode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "access_keys" => true,
            "iam_role" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ObservabilityS3DestinationConfigAuthMode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityS3DestinationConfigAuthMode other && Equals(other);
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
        public static bool operator ==(ObservabilityS3DestinationConfigAuthMode left, ObservabilityS3DestinationConfigAuthMode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ObservabilityS3DestinationConfigAuthMode left, ObservabilityS3DestinationConfigAuthMode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityS3DestinationConfigAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityS3DestinationConfigAuthMode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityS3DestinationConfigAuthMode? ToEnum(string value)
        {
            return ObservabilityS3DestinationConfigAuthMode.FromValue(value);
        }
    }
}