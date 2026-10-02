
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Canonical OpenRouter error type, stable across all API formats<br/>
    /// Example: rate_limit_exceeded
    /// </summary>
    public readonly partial struct ApiErrorType : global::System.IEquatable<ApiErrorType>
    {
        /// <summary>
        ///
        /// </summary>
        public ApiErrorType(string value)
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
        public static ApiErrorType Authentication { get; } = new("authentication");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType ContentPolicyViolation { get; } = new("content_policy_violation");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType ContextLengthExceeded { get; } = new("context_length_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType ImageDownloadFailed { get; } = new("image_download_failed");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType ImageNotFound { get; } = new("image_not_found");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType ImageTooLarge { get; } = new("image_too_large");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType ImageTooSmall { get; } = new("image_too_small");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType InvalidImage { get; } = new("invalid_image");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType InvalidPrompt { get; } = new("invalid_prompt");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType InvalidRequest { get; } = new("invalid_request");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType MaxTokensExceeded { get; } = new("max_tokens_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType NotFound { get; } = new("not_found");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType PayloadTooLarge { get; } = new("payload_too_large");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType PaymentRequired { get; } = new("payment_required");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType PermissionDenied { get; } = new("permission_denied");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType PreconditionFailed { get; } = new("precondition_failed");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType ProviderOverloaded { get; } = new("provider_overloaded");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType ProviderUnavailable { get; } = new("provider_unavailable");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType RateLimitExceeded { get; } = new("rate_limit_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType Refusal { get; } = new("refusal");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType Server { get; } = new("server");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType StringTooLong { get; } = new("string_too_long");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType Timeout { get; } = new("timeout");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType TokenLimitExceeded { get; } = new("token_limit_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType Unmapped { get; } = new("unmapped");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType Unprocessable { get; } = new("unprocessable");

        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType UnsupportedImageFormat { get; } = new("unsupported_image_format");
        /// <summary>
        ///
        /// </summary>
        public static ApiErrorType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "authentication" => Authentication,
                "content_policy_violation" => ContentPolicyViolation,
                "context_length_exceeded" => ContextLengthExceeded,
                "image_download_failed" => ImageDownloadFailed,
                "image_not_found" => ImageNotFound,
                "image_too_large" => ImageTooLarge,
                "image_too_small" => ImageTooSmall,
                "invalid_image" => InvalidImage,
                "invalid_prompt" => InvalidPrompt,
                "invalid_request" => InvalidRequest,
                "max_tokens_exceeded" => MaxTokensExceeded,
                "not_found" => NotFound,
                "payload_too_large" => PayloadTooLarge,
                "payment_required" => PaymentRequired,
                "permission_denied" => PermissionDenied,
                "precondition_failed" => PreconditionFailed,
                "provider_overloaded" => ProviderOverloaded,
                "provider_unavailable" => ProviderUnavailable,
                "rate_limit_exceeded" => RateLimitExceeded,
                "refusal" => Refusal,
                "server" => Server,
                "string_too_long" => StringTooLong,
                "timeout" => Timeout,
                "token_limit_exceeded" => TokenLimitExceeded,
                "unmapped" => Unmapped,
                "unprocessable" => Unprocessable,
                "unsupported_image_format" => UnsupportedImageFormat,
                _ => new ApiErrorType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "authentication" => true,
            "content_policy_violation" => true,
            "context_length_exceeded" => true,
            "image_download_failed" => true,
            "image_not_found" => true,
            "image_too_large" => true,
            "image_too_small" => true,
            "invalid_image" => true,
            "invalid_prompt" => true,
            "invalid_request" => true,
            "max_tokens_exceeded" => true,
            "not_found" => true,
            "payload_too_large" => true,
            "payment_required" => true,
            "permission_denied" => true,
            "precondition_failed" => true,
            "provider_overloaded" => true,
            "provider_unavailable" => true,
            "rate_limit_exceeded" => true,
            "refusal" => true,
            "server" => true,
            "string_too_long" => true,
            "timeout" => true,
            "token_limit_exceeded" => true,
            "unmapped" => true,
            "unprocessable" => true,
            "unsupported_image_format" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ApiErrorType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApiErrorType other && Equals(other);
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
        public static bool operator ==(ApiErrorType left, ApiErrorType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ApiErrorType left, ApiErrorType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiErrorType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiErrorType? ToEnum(string value)
        {
            return ApiErrorType.FromValue(value);
        }
    }
}