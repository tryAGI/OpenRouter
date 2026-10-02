
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The format of the output embeddings<br/>
    /// Example: float
    /// </summary>
    public readonly partial struct CreateEmbeddingsRequestEncodingFormat : global::System.IEquatable<CreateEmbeddingsRequestEncodingFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public CreateEmbeddingsRequestEncodingFormat(string value)
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
        public static CreateEmbeddingsRequestEncodingFormat Base64 { get; } = new("base64");

        /// <summary>
        ///
        /// </summary>
        public static CreateEmbeddingsRequestEncodingFormat Float { get; } = new("float");
        /// <summary>
        ///
        /// </summary>
        public static CreateEmbeddingsRequestEncodingFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "base64" => Base64,
                "float" => Float,
                _ => new CreateEmbeddingsRequestEncodingFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "base64" => true,
            "float" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CreateEmbeddingsRequestEncodingFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEmbeddingsRequestEncodingFormat other && Equals(other);
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
        public static bool operator ==(CreateEmbeddingsRequestEncodingFormat left, CreateEmbeddingsRequestEncodingFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateEmbeddingsRequestEncodingFormat left, CreateEmbeddingsRequestEncodingFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingsRequestEncodingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingsRequestEncodingFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingsRequestEncodingFormat? ToEnum(string value)
        {
            return CreateEmbeddingsRequestEncodingFormat.FromValue(value);
        }
    }
}