
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AdditionalToolsItemRole : global::System.IEquatable<AdditionalToolsItemRole>
    {
        /// <summary>
        ///
        /// </summary>
        public AdditionalToolsItemRole(string value)
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
        public static AdditionalToolsItemRole Assistant { get; } = new("assistant");

        /// <summary>
        ///
        /// </summary>
        public static AdditionalToolsItemRole Critic { get; } = new("critic");

        /// <summary>
        ///
        /// </summary>
        public static AdditionalToolsItemRole Developer { get; } = new("developer");

        /// <summary>
        ///
        /// </summary>
        public static AdditionalToolsItemRole Discriminator { get; } = new("discriminator");

        /// <summary>
        ///
        /// </summary>
        public static AdditionalToolsItemRole System { get; } = new("system");

        /// <summary>
        ///
        /// </summary>
        public static AdditionalToolsItemRole Tool { get; } = new("tool");

        /// <summary>
        ///
        /// </summary>
        public static AdditionalToolsItemRole Unknown { get; } = new("unknown");

        /// <summary>
        ///
        /// </summary>
        public static AdditionalToolsItemRole User { get; } = new("user");
        /// <summary>
        ///
        /// </summary>
        public static AdditionalToolsItemRole FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "assistant" => Assistant,
                "critic" => Critic,
                "developer" => Developer,
                "discriminator" => Discriminator,
                "system" => System,
                "tool" => Tool,
                "unknown" => Unknown,
                "user" => User,
                _ => new AdditionalToolsItemRole(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "assistant" => true,
            "critic" => true,
            "developer" => true,
            "discriminator" => true,
            "system" => true,
            "tool" => true,
            "unknown" => true,
            "user" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AdditionalToolsItemRole other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AdditionalToolsItemRole other && Equals(other);
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
        public static bool operator ==(AdditionalToolsItemRole left, AdditionalToolsItemRole right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AdditionalToolsItemRole left, AdditionalToolsItemRole right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdditionalToolsItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdditionalToolsItemRole value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdditionalToolsItemRole? ToEnum(string value)
        {
            return AdditionalToolsItemRole.FromValue(value);
        }
    }
}