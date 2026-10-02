
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Whether the engine needs the caller's own key, saved in plugin settings: `required` (OpenRouter holds none), `optional` (OpenRouter's key is used unless the caller saved one), or `none`<br/>
    /// Example: none
    /// </summary>
    public readonly partial struct ServerToolEngineByok : global::System.IEquatable<ServerToolEngineByok>
    {
        /// <summary>
        ///
        /// </summary>
        public ServerToolEngineByok(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `required` (OpenRouter holds none), `optional` (OpenRouter's key is used unless the caller saved one), or `none`
        /// </summary>
        public static ServerToolEngineByok None { get; } = new("none");

        /// <summary>
        /// `required` (OpenRouter holds none), `optional` (OpenRouter's key is used unless the caller saved one), or `none`
        /// </summary>
        public static ServerToolEngineByok Optional { get; } = new("optional");

        /// <summary>
        /// `required` (OpenRouter holds none), `optional` (OpenRouter's key is used unless the caller saved one), or `none`
        /// </summary>
        public static ServerToolEngineByok Required { get; } = new("required");
        /// <summary>
        ///
        /// </summary>
        public static ServerToolEngineByok FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "none" => None,
                "optional" => Optional,
                "required" => Required,
                _ => new ServerToolEngineByok(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "none" => true,
            "optional" => true,
            "required" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ServerToolEngineByok other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerToolEngineByok other && Equals(other);
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
        public static bool operator ==(ServerToolEngineByok left, ServerToolEngineByok right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerToolEngineByok left, ServerToolEngineByok right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerToolEngineByokExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerToolEngineByok value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerToolEngineByok? ToEnum(string value)
        {
            return ServerToolEngineByok.FromValue(value);
        }
    }
}