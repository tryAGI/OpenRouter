
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `b64_json` (default) returns the image bytes inline. `url` stores each output in OpenRouter storage and returns a signed download URL in place of the bytes. The URL is a bearer link: anyone holding it can download the image until it expires, up to 24 hours after the image was stored (use `expires_at`); the stored copy is deleted by the storage lifecycle within the following day. The response falls back to `b64_json` when a URL cannot be issued: streaming responses, zero-data-retention requests (account settings, guardrails or `provider.zdr`) or endpoints, or storage being unavailable.<br/>
    /// Example: b64_json
    /// </summary>
    public readonly partial struct ImageGenerationRequestResponseFormat : global::System.IEquatable<ImageGenerationRequestResponseFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequestResponseFormat(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// anyone holding it can download the image until it expires, up to 24 hours after the image was stored (use `expires_at`); the stored copy is deleted by the storage lifecycle within the following day. The response falls back to `b64_json` when a URL cannot be issued: streaming responses, zero-data-retention requests (account settings, guardrails or `provider.zdr`) or endpoints, or storage being unavailable.
        /// </summary>
        public static ImageGenerationRequestResponseFormat B64Json { get; } = new("b64_json");

        /// <summary>
        /// anyone holding it can download the image until it expires, up to 24 hours after the image was stored (use `expires_at`); the stored copy is deleted by the storage lifecycle within the following day. The response falls back to `b64_json` when a URL cannot be issued: streaming responses, zero-data-retention requests (account settings, guardrails or `provider.zdr`) or endpoints, or storage being unavailable.
        /// </summary>
        public static ImageGenerationRequestResponseFormat Url { get; } = new("url");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestResponseFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "b64_json" => B64Json,
                "url" => Url,
                _ => new ImageGenerationRequestResponseFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "b64_json" => true,
            "url" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageGenerationRequestResponseFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationRequestResponseFormat other && Equals(other);
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
        public static bool operator ==(ImageGenerationRequestResponseFormat left, ImageGenerationRequestResponseFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationRequestResponseFormat left, ImageGenerationRequestResponseFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestResponseFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestResponseFormat? ToEnum(string value)
        {
            return ImageGenerationRequestResponseFormat.FromValue(value);
        }
    }
}