
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicWebFetchToolResultErrorErrorCode : global::System.IEquatable<AnthropicWebFetchToolResultErrorErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicWebFetchToolResultErrorErrorCode(string value)
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
        public static AnthropicWebFetchToolResultErrorErrorCode ContentTooLarge { get; } = new("content_too_large");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode InvalidToolInput { get; } = new("invalid_tool_input");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode MaxUsesExceeded { get; } = new("max_uses_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode TooManyRequests { get; } = new("too_many_requests");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode Unavailable { get; } = new("unavailable");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode UnsupportedContentType { get; } = new("unsupported_content_type");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode UrlNotAccessible { get; } = new("url_not_accessible");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode UrlNotAllowed { get; } = new("url_not_allowed");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode UrlNotInPriorContext { get; } = new("url_not_in_prior_context");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode UrlTooLong { get; } = new("url_too_long");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "content_too_large" => ContentTooLarge,
                "invalid_tool_input" => InvalidToolInput,
                "max_uses_exceeded" => MaxUsesExceeded,
                "too_many_requests" => TooManyRequests,
                "unavailable" => Unavailable,
                "unsupported_content_type" => UnsupportedContentType,
                "url_not_accessible" => UrlNotAccessible,
                "url_not_allowed" => UrlNotAllowed,
                "url_not_in_prior_context" => UrlNotInPriorContext,
                "url_too_long" => UrlTooLong,
                _ => new AnthropicWebFetchToolResultErrorErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "content_too_large" => true,
            "invalid_tool_input" => true,
            "max_uses_exceeded" => true,
            "too_many_requests" => true,
            "unavailable" => true,
            "unsupported_content_type" => true,
            "url_not_accessible" => true,
            "url_not_allowed" => true,
            "url_not_in_prior_context" => true,
            "url_too_long" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicWebFetchToolResultErrorErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicWebFetchToolResultErrorErrorCode other && Equals(other);
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
        public static bool operator ==(AnthropicWebFetchToolResultErrorErrorCode left, AnthropicWebFetchToolResultErrorErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicWebFetchToolResultErrorErrorCode left, AnthropicWebFetchToolResultErrorErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebFetchToolResultErrorErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebFetchToolResultErrorErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode? ToEnum(string value)
        {
            return AnthropicWebFetchToolResultErrorErrorCode.FromValue(value);
        }
    }
}