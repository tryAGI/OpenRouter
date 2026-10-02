
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The service tier to use for processing this request. `fast` is accepted as an alias for `priority`. `ultrafast` prefers ultrafast endpoints and falls back to `priority`, then default endpoints.<br/>
    /// Default Value: auto
    /// </summary>
    public readonly partial struct ResponsesRequestServiceTier : global::System.IEquatable<ResponsesRequestServiceTier>
    {
        /// <summary>
        ///
        /// </summary>
        public ResponsesRequestServiceTier(string value)
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
        public static ResponsesRequestServiceTier Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesRequestServiceTier Default { get; } = new("default");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesRequestServiceTier Fast { get; } = new("fast");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesRequestServiceTier Flex { get; } = new("flex");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesRequestServiceTier Priority { get; } = new("priority");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesRequestServiceTier Scale { get; } = new("scale");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesRequestServiceTier Ultrafast { get; } = new("ultrafast");
        /// <summary>
        ///
        /// </summary>
        public static ResponsesRequestServiceTier FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "default" => Default,
                "fast" => Fast,
                "flex" => Flex,
                "priority" => Priority,
                "scale" => Scale,
                "ultrafast" => Ultrafast,
                _ => new ResponsesRequestServiceTier(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "default" => true,
            "fast" => true,
            "flex" => true,
            "priority" => true,
            "scale" => true,
            "ultrafast" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ResponsesRequestServiceTier other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestServiceTier other && Equals(other);
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
        public static bool operator ==(ResponsesRequestServiceTier left, ResponsesRequestServiceTier right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponsesRequestServiceTier left, ResponsesRequestServiceTier right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestServiceTier value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestServiceTier? ToEnum(string value)
        {
            return ResponsesRequestServiceTier.FromValue(value);
        }
    }
}