
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ServerToolInputNameApiFormat : global::System.IEquatable<ServerToolInputNameApiFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public ServerToolInputNameApiFormat(string value)
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
        public static ServerToolInputNameApiFormat AnthropicMessages { get; } = new("anthropic-messages");

        /// <summary>
        ///
        /// </summary>
        public static ServerToolInputNameApiFormat ChatCompletions { get; } = new("chat-completions");

        /// <summary>
        ///
        /// </summary>
        public static ServerToolInputNameApiFormat Responses { get; } = new("responses");
        /// <summary>
        ///
        /// </summary>
        public static ServerToolInputNameApiFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "anthropic-messages" => AnthropicMessages,
                "chat-completions" => ChatCompletions,
                "responses" => Responses,
                _ => new ServerToolInputNameApiFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "anthropic-messages" => true,
            "chat-completions" => true,
            "responses" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ServerToolInputNameApiFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerToolInputNameApiFormat other && Equals(other);
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
        public static bool operator ==(ServerToolInputNameApiFormat left, ServerToolInputNameApiFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerToolInputNameApiFormat left, ServerToolInputNameApiFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerToolInputNameApiFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerToolInputNameApiFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerToolInputNameApiFormat? ToEnum(string value)
        {
            return ServerToolInputNameApiFormat.FromValue(value);
        }
    }
}