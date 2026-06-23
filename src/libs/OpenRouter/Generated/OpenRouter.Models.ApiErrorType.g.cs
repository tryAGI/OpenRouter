
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Canonical OpenRouter error type, stable across all API formats
    /// </summary>
    public enum ApiErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        Authentication,
        /// <summary>
        /// 
        /// </summary>
        ContentPolicyViolation,
        /// <summary>
        /// 
        /// </summary>
        ContextLengthExceeded,
        /// <summary>
        /// 
        /// </summary>
        ImageDownloadFailed,
        /// <summary>
        /// 
        /// </summary>
        ImageNotFound,
        /// <summary>
        /// 
        /// </summary>
        ImageTooLarge,
        /// <summary>
        /// 
        /// </summary>
        ImageTooSmall,
        /// <summary>
        /// 
        /// </summary>
        InvalidImage,
        /// <summary>
        /// 
        /// </summary>
        InvalidPrompt,
        /// <summary>
        /// 
        /// </summary>
        InvalidRequest,
        /// <summary>
        /// 
        /// </summary>
        MaxTokensExceeded,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        PayloadTooLarge,
        /// <summary>
        /// 
        /// </summary>
        PaymentRequired,
        /// <summary>
        /// 
        /// </summary>
        PermissionDenied,
        /// <summary>
        /// 
        /// </summary>
        PreconditionFailed,
        /// <summary>
        /// 
        /// </summary>
        ProviderOverloaded,
        /// <summary>
        /// 
        /// </summary>
        ProviderUnavailable,
        /// <summary>
        /// 
        /// </summary>
        RateLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        Refusal,
        /// <summary>
        /// 
        /// </summary>
        Server,
        /// <summary>
        /// 
        /// </summary>
        StringTooLong,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        TokenLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        Unmapped,
        /// <summary>
        /// 
        /// </summary>
        Unprocessable,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedImageFormat,
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
            return value switch
            {
                ApiErrorType.Authentication => "authentication",
                ApiErrorType.ContentPolicyViolation => "content_policy_violation",
                ApiErrorType.ContextLengthExceeded => "context_length_exceeded",
                ApiErrorType.ImageDownloadFailed => "image_download_failed",
                ApiErrorType.ImageNotFound => "image_not_found",
                ApiErrorType.ImageTooLarge => "image_too_large",
                ApiErrorType.ImageTooSmall => "image_too_small",
                ApiErrorType.InvalidImage => "invalid_image",
                ApiErrorType.InvalidPrompt => "invalid_prompt",
                ApiErrorType.InvalidRequest => "invalid_request",
                ApiErrorType.MaxTokensExceeded => "max_tokens_exceeded",
                ApiErrorType.NotFound => "not_found",
                ApiErrorType.PayloadTooLarge => "payload_too_large",
                ApiErrorType.PaymentRequired => "payment_required",
                ApiErrorType.PermissionDenied => "permission_denied",
                ApiErrorType.PreconditionFailed => "precondition_failed",
                ApiErrorType.ProviderOverloaded => "provider_overloaded",
                ApiErrorType.ProviderUnavailable => "provider_unavailable",
                ApiErrorType.RateLimitExceeded => "rate_limit_exceeded",
                ApiErrorType.Refusal => "refusal",
                ApiErrorType.Server => "server",
                ApiErrorType.StringTooLong => "string_too_long",
                ApiErrorType.Timeout => "timeout",
                ApiErrorType.TokenLimitExceeded => "token_limit_exceeded",
                ApiErrorType.Unmapped => "unmapped",
                ApiErrorType.Unprocessable => "unprocessable",
                ApiErrorType.UnsupportedImageFormat => "unsupported_image_format",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authentication" => ApiErrorType.Authentication,
                "content_policy_violation" => ApiErrorType.ContentPolicyViolation,
                "context_length_exceeded" => ApiErrorType.ContextLengthExceeded,
                "image_download_failed" => ApiErrorType.ImageDownloadFailed,
                "image_not_found" => ApiErrorType.ImageNotFound,
                "image_too_large" => ApiErrorType.ImageTooLarge,
                "image_too_small" => ApiErrorType.ImageTooSmall,
                "invalid_image" => ApiErrorType.InvalidImage,
                "invalid_prompt" => ApiErrorType.InvalidPrompt,
                "invalid_request" => ApiErrorType.InvalidRequest,
                "max_tokens_exceeded" => ApiErrorType.MaxTokensExceeded,
                "not_found" => ApiErrorType.NotFound,
                "payload_too_large" => ApiErrorType.PayloadTooLarge,
                "payment_required" => ApiErrorType.PaymentRequired,
                "permission_denied" => ApiErrorType.PermissionDenied,
                "precondition_failed" => ApiErrorType.PreconditionFailed,
                "provider_overloaded" => ApiErrorType.ProviderOverloaded,
                "provider_unavailable" => ApiErrorType.ProviderUnavailable,
                "rate_limit_exceeded" => ApiErrorType.RateLimitExceeded,
                "refusal" => ApiErrorType.Refusal,
                "server" => ApiErrorType.Server,
                "string_too_long" => ApiErrorType.StringTooLong,
                "timeout" => ApiErrorType.Timeout,
                "token_limit_exceeded" => ApiErrorType.TokenLimitExceeded,
                "unmapped" => ApiErrorType.Unmapped,
                "unprocessable" => ApiErrorType.Unprocessable,
                "unsupported_image_format" => ApiErrorType.UnsupportedImageFormat,
                _ => null,
            };
        }
    }
}