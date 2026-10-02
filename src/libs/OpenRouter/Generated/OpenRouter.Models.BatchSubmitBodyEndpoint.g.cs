
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BatchSubmitBodyEndpoint : global::System.IEquatable<BatchSubmitBodyEndpoint>
    {
        /// <summary>
        ///
        /// </summary>
        public BatchSubmitBodyEndpoint(string value)
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
        public static BatchSubmitBodyEndpoint V1ChatCompletions { get; } = new("/v1/chat/completions");

        /// <summary>
        ///
        /// </summary>
        public static BatchSubmitBodyEndpoint V1Embeddings { get; } = new("/v1/embeddings");

        /// <summary>
        ///
        /// </summary>
        public static BatchSubmitBodyEndpoint V1Messages { get; } = new("/v1/messages");

        /// <summary>
        ///
        /// </summary>
        public static BatchSubmitBodyEndpoint V1Responses { get; } = new("/v1/responses");
        /// <summary>
        ///
        /// </summary>
        public static BatchSubmitBodyEndpoint FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "/v1/chat/completions" => V1ChatCompletions,
                "/v1/embeddings" => V1Embeddings,
                "/v1/messages" => V1Messages,
                "/v1/responses" => V1Responses,
                _ => new BatchSubmitBodyEndpoint(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "/v1/chat/completions" => true,
            "/v1/embeddings" => true,
            "/v1/messages" => true,
            "/v1/responses" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BatchSubmitBodyEndpoint other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BatchSubmitBodyEndpoint other && Equals(other);
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
        public static bool operator ==(BatchSubmitBodyEndpoint left, BatchSubmitBodyEndpoint right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BatchSubmitBodyEndpoint left, BatchSubmitBodyEndpoint right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchSubmitBodyEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchSubmitBodyEndpoint value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchSubmitBodyEndpoint? ToEnum(string value)
        {
            return BatchSubmitBodyEndpoint.FromValue(value);
        }
    }
}