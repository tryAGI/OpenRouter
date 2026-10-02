
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponsesErrorFieldCode : global::System.IEquatable<ResponsesErrorFieldCode>
    {
        /// <summary>
        ///
        /// </summary>
        public ResponsesErrorFieldCode(string value)
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
        public static ResponsesErrorFieldCode BioPolicy { get; } = new("bio_policy");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode CyberPolicy { get; } = new("cyber_policy");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode DataResidencyMismatch { get; } = new("data_residency_mismatch");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode EmptyImageFile { get; } = new("empty_image_file");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode FailedToDownloadImage { get; } = new("failed_to_download_image");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode ImageContentPolicyViolation { get; } = new("image_content_policy_violation");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode ImageFileNotFound { get; } = new("image_file_not_found");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode ImageFileTooLarge { get; } = new("image_file_too_large");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode ImageParseError { get; } = new("image_parse_error");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode ImageTooLarge { get; } = new("image_too_large");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode ImageTooSmall { get; } = new("image_too_small");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode InvalidBase64Image { get; } = new("invalid_base64_image");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode InvalidImage { get; } = new("invalid_image");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode InvalidImageFormat { get; } = new("invalid_image_format");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode InvalidImageMode { get; } = new("invalid_image_mode");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode InvalidImageUrl { get; } = new("invalid_image_url");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode InvalidPrompt { get; } = new("invalid_prompt");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode MisalignmentPolicyViolation { get; } = new("misalignment_policy_violation");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode RateLimitExceeded { get; } = new("rate_limit_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode ServerError { get; } = new("server_error");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode UnsupportedImageMediaType { get; } = new("unsupported_image_media_type");

        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode VectorStoreTimeout { get; } = new("vector_store_timeout");
        /// <summary>
        ///
        /// </summary>
        public static ResponsesErrorFieldCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "bio_policy" => BioPolicy,
                "cyber_policy" => CyberPolicy,
                "data_residency_mismatch" => DataResidencyMismatch,
                "empty_image_file" => EmptyImageFile,
                "failed_to_download_image" => FailedToDownloadImage,
                "image_content_policy_violation" => ImageContentPolicyViolation,
                "image_file_not_found" => ImageFileNotFound,
                "image_file_too_large" => ImageFileTooLarge,
                "image_parse_error" => ImageParseError,
                "image_too_large" => ImageTooLarge,
                "image_too_small" => ImageTooSmall,
                "invalid_base64_image" => InvalidBase64Image,
                "invalid_image" => InvalidImage,
                "invalid_image_format" => InvalidImageFormat,
                "invalid_image_mode" => InvalidImageMode,
                "invalid_image_url" => InvalidImageUrl,
                "invalid_prompt" => InvalidPrompt,
                "misalignment_policy_violation" => MisalignmentPolicyViolation,
                "rate_limit_exceeded" => RateLimitExceeded,
                "server_error" => ServerError,
                "unsupported_image_media_type" => UnsupportedImageMediaType,
                "vector_store_timeout" => VectorStoreTimeout,
                _ => new ResponsesErrorFieldCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "bio_policy" => true,
            "cyber_policy" => true,
            "data_residency_mismatch" => true,
            "empty_image_file" => true,
            "failed_to_download_image" => true,
            "image_content_policy_violation" => true,
            "image_file_not_found" => true,
            "image_file_too_large" => true,
            "image_parse_error" => true,
            "image_too_large" => true,
            "image_too_small" => true,
            "invalid_base64_image" => true,
            "invalid_image" => true,
            "invalid_image_format" => true,
            "invalid_image_mode" => true,
            "invalid_image_url" => true,
            "invalid_prompt" => true,
            "misalignment_policy_violation" => true,
            "rate_limit_exceeded" => true,
            "server_error" => true,
            "unsupported_image_media_type" => true,
            "vector_store_timeout" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ResponsesErrorFieldCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesErrorFieldCode other && Equals(other);
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
        public static bool operator ==(ResponsesErrorFieldCode left, ResponsesErrorFieldCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponsesErrorFieldCode left, ResponsesErrorFieldCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesErrorFieldCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesErrorFieldCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesErrorFieldCode? ToEnum(string value)
        {
            return ResponsesErrorFieldCode.FromValue(value);
        }
    }
}