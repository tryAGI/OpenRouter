
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Optional credit limit reset interval. When set, the credit limit resets on this interval.<br/>
    /// Example: monthly
    /// </summary>
    public readonly partial struct CreateAuthKeysCodeRequestUsageLimitType : global::System.IEquatable<CreateAuthKeysCodeRequestUsageLimitType>
    {
        /// <summary>
        ///
        /// </summary>
        public CreateAuthKeysCodeRequestUsageLimitType(string value)
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
        public static CreateAuthKeysCodeRequestUsageLimitType Daily { get; } = new("daily");

        /// <summary>
        ///
        /// </summary>
        public static CreateAuthKeysCodeRequestUsageLimitType Monthly { get; } = new("monthly");

        /// <summary>
        ///
        /// </summary>
        public static CreateAuthKeysCodeRequestUsageLimitType Weekly { get; } = new("weekly");
        /// <summary>
        ///
        /// </summary>
        public static CreateAuthKeysCodeRequestUsageLimitType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "daily" => Daily,
                "monthly" => Monthly,
                "weekly" => Weekly,
                _ => new CreateAuthKeysCodeRequestUsageLimitType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "daily" => true,
            "monthly" => true,
            "weekly" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CreateAuthKeysCodeRequestUsageLimitType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAuthKeysCodeRequestUsageLimitType other && Equals(other);
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
        public static bool operator ==(CreateAuthKeysCodeRequestUsageLimitType left, CreateAuthKeysCodeRequestUsageLimitType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateAuthKeysCodeRequestUsageLimitType left, CreateAuthKeysCodeRequestUsageLimitType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAuthKeysCodeRequestUsageLimitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAuthKeysCodeRequestUsageLimitType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAuthKeysCodeRequestUsageLimitType? ToEnum(string value)
        {
            return CreateAuthKeysCodeRequestUsageLimitType.FromValue(value);
        }
    }
}