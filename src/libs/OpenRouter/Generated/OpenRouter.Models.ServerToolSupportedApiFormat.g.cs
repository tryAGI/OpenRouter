
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ServerToolSupportedApiFormat : global::System.IEquatable<ServerToolSupportedApiFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public ServerToolSupportedApiFormat(string value)
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
        public static ServerToolSupportedApiFormat AnthropicMessages { get; } = new("anthropic-messages");

        /// <summary>
        ///
        /// </summary>
        public static ServerToolSupportedApiFormat ChatCompletions { get; } = new("chat-completions");

        /// <summary>
        ///
        /// </summary>
        public static ServerToolSupportedApiFormat Responses { get; } = new("responses");
        /// <summary>
        ///
        /// </summary>
        public static ServerToolSupportedApiFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "anthropic-messages" => AnthropicMessages,
                "chat-completions" => ChatCompletions,
                "responses" => Responses,
                _ => new ServerToolSupportedApiFormat(value),
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
        public bool Equals(ServerToolSupportedApiFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerToolSupportedApiFormat other && Equals(other);
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
        public static bool operator ==(ServerToolSupportedApiFormat left, ServerToolSupportedApiFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerToolSupportedApiFormat left, ServerToolSupportedApiFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerToolSupportedApiFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerToolSupportedApiFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerToolSupportedApiFormat? ToEnum(string value)
        {
            return ServerToolSupportedApiFormat.FromValue(value);
        }
    }
}