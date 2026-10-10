
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponsesRequestToolVariant1AllowedCaller : global::System.IEquatable<ResponsesRequestToolVariant1AllowedCaller>
    {
        /// <summary>
        ///
        /// </summary>
        public ResponsesRequestToolVariant1AllowedCaller(string value)
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
        public static ResponsesRequestToolVariant1AllowedCaller Direct { get; } = new("direct");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesRequestToolVariant1AllowedCaller Programmatic { get; } = new("programmatic");
        /// <summary>
        ///
        /// </summary>
        public static ResponsesRequestToolVariant1AllowedCaller FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "direct" => Direct,
                "programmatic" => Programmatic,
                _ => new ResponsesRequestToolVariant1AllowedCaller(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "direct" => true,
            "programmatic" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ResponsesRequestToolVariant1AllowedCaller other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestToolVariant1AllowedCaller other && Equals(other);
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
        public static bool operator ==(ResponsesRequestToolVariant1AllowedCaller left, ResponsesRequestToolVariant1AllowedCaller right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponsesRequestToolVariant1AllowedCaller left, ResponsesRequestToolVariant1AllowedCaller right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestToolVariant1AllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestToolVariant1AllowedCaller value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestToolVariant1AllowedCaller? ToEnum(string value)
        {
            return ResponsesRequestToolVariant1AllowedCaller.FromValue(value);
        }
    }
}