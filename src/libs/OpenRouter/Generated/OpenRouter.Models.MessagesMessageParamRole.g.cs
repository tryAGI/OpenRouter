
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct MessagesMessageParamRole : global::System.IEquatable<MessagesMessageParamRole>
    {
        /// <summary>
        ///
        /// </summary>
        public MessagesMessageParamRole(string value)
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
        public static MessagesMessageParamRole Assistant { get; } = new("assistant");

        /// <summary>
        ///
        /// </summary>
        public static MessagesMessageParamRole System { get; } = new("system");

        /// <summary>
        ///
        /// </summary>
        public static MessagesMessageParamRole User { get; } = new("user");
        /// <summary>
        ///
        /// </summary>
        public static MessagesMessageParamRole FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "assistant" => Assistant,
                "system" => System,
                "user" => User,
                _ => new MessagesMessageParamRole(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "assistant" => true,
            "system" => true,
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
        public bool Equals(MessagesMessageParamRole other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesMessageParamRole other && Equals(other);
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
        public static bool operator ==(MessagesMessageParamRole left, MessagesMessageParamRole right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MessagesMessageParamRole left, MessagesMessageParamRole right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamRole value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamRole? ToEnum(string value)
        {
            return MessagesMessageParamRole.FromValue(value);
        }
    }
}