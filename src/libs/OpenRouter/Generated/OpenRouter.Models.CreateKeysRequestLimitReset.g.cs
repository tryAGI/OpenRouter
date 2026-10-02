
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.<br/>
    /// Example: monthly
    /// </summary>
    public readonly partial struct CreateKeysRequestLimitReset : global::System.IEquatable<CreateKeysRequestLimitReset>
    {
        /// <summary>
        ///
        /// </summary>
        public CreateKeysRequestLimitReset(string value)
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
        public static CreateKeysRequestLimitReset Daily { get; } = new("daily");

        /// <summary>
        ///
        /// </summary>
        public static CreateKeysRequestLimitReset Monthly { get; } = new("monthly");

        /// <summary>
        ///
        /// </summary>
        public static CreateKeysRequestLimitReset Weekly { get; } = new("weekly");
        /// <summary>
        ///
        /// </summary>
        public static CreateKeysRequestLimitReset FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "daily" => Daily,
                "monthly" => Monthly,
                "weekly" => Weekly,
                _ => new CreateKeysRequestLimitReset(value),
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
        public bool Equals(CreateKeysRequestLimitReset other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateKeysRequestLimitReset other && Equals(other);
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
        public static bool operator ==(CreateKeysRequestLimitReset left, CreateKeysRequestLimitReset right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateKeysRequestLimitReset left, CreateKeysRequestLimitReset right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKeysRequestLimitResetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKeysRequestLimitReset value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKeysRequestLimitReset? ToEnum(string value)
        {
            return CreateKeysRequestLimitReset.FromValue(value);
        }
    }
}