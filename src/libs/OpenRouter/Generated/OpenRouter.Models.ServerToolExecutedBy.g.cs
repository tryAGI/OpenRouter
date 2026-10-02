
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Who runs the tool call: the model provider during inference (`provider`), OpenRouter (`openrouter`), or the caller's application after the call is returned (`client`).<br/>
    /// Example: openrouter
    /// </summary>
    public readonly partial struct ServerToolExecutedBy : global::System.IEquatable<ServerToolExecutedBy>
    {
        /// <summary>
        ///
        /// </summary>
        public ServerToolExecutedBy(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// the model provider during inference (`provider`), OpenRouter (`openrouter`), or the caller's application after the call is returned (`client`).
        /// </summary>
        public static ServerToolExecutedBy Client { get; } = new("client");

        /// <summary>
        /// the model provider during inference (`provider`), OpenRouter (`openrouter`), or the caller's application after the call is returned (`client`).
        /// </summary>
        public static ServerToolExecutedBy Openrouter { get; } = new("openrouter");

        /// <summary>
        /// the model provider during inference (`provider`), OpenRouter (`openrouter`), or the caller's application after the call is returned (`client`).
        /// </summary>
        public static ServerToolExecutedBy Provider { get; } = new("provider");
        /// <summary>
        ///
        /// </summary>
        public static ServerToolExecutedBy FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "client" => Client,
                "openrouter" => Openrouter,
                "provider" => Provider,
                _ => new ServerToolExecutedBy(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "client" => true,
            "openrouter" => true,
            "provider" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ServerToolExecutedBy other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerToolExecutedBy other && Equals(other);
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
        public static bool operator ==(ServerToolExecutedBy left, ServerToolExecutedBy right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerToolExecutedBy left, ServerToolExecutedBy right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerToolExecutedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerToolExecutedBy value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerToolExecutedBy? ToEnum(string value)
        {
            return ServerToolExecutedBy.FromValue(value);
        }
    }
}