
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.<br/>
    /// Example: daily
    /// </summary>
    public readonly partial struct UpdateKeysRequestLimitReset : global::System.IEquatable<UpdateKeysRequestLimitReset>
    {
        /// <summary>
        ///
        /// </summary>
        public UpdateKeysRequestLimitReset(string value)
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
        public static UpdateKeysRequestLimitReset Daily { get; } = new("daily");

        /// <summary>
        ///
        /// </summary>
        public static UpdateKeysRequestLimitReset Monthly { get; } = new("monthly");

        /// <summary>
        ///
        /// </summary>
        public static UpdateKeysRequestLimitReset Weekly { get; } = new("weekly");
        /// <summary>
        ///
        /// </summary>
        public static UpdateKeysRequestLimitReset FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "daily" => Daily,
                "monthly" => Monthly,
                "weekly" => Weekly,
                _ => new UpdateKeysRequestLimitReset(value),
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
        public bool Equals(UpdateKeysRequestLimitReset other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateKeysRequestLimitReset other && Equals(other);
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
        public static bool operator ==(UpdateKeysRequestLimitReset left, UpdateKeysRequestLimitReset right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateKeysRequestLimitReset left, UpdateKeysRequestLimitReset right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateKeysRequestLimitResetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKeysRequestLimitReset value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKeysRequestLimitReset? ToEnum(string value)
        {
            return UpdateKeysRequestLimitReset.FromValue(value);
        }
    }
}