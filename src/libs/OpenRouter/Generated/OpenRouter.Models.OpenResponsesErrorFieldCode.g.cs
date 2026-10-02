
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OpenResponsesErrorFieldCode : global::System.IEquatable<OpenResponsesErrorFieldCode>
    {
        /// <summary>
        ///
        /// </summary>
        public OpenResponsesErrorFieldCode(string value)
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
        public static OpenResponsesErrorFieldCode BioPolicy { get; } = new("bio_policy");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode CyberPolicy { get; } = new("cyber_policy");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode DataResidencyMismatch { get; } = new("data_residency_mismatch");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode EmptyImageFile { get; } = new("empty_image_file");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode FailedToDownloadImage { get; } = new("failed_to_download_image");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode ImageContentPolicyViolation { get; } = new("image_content_policy_violation");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode ImageFileNotFound { get; } = new("image_file_not_found");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode ImageFileTooLarge { get; } = new("image_file_too_large");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode ImageParseError { get; } = new("image_parse_error");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode ImageTooLarge { get; } = new("image_too_large");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode ImageTooSmall { get; } = new("image_too_small");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode InvalidBase64Image { get; } = new("invalid_base64_image");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode InvalidImage { get; } = new("invalid_image");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode InvalidImageFormat { get; } = new("invalid_image_format");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode InvalidImageMode { get; } = new("invalid_image_mode");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode InvalidImageUrl { get; } = new("invalid_image_url");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode InvalidPrompt { get; } = new("invalid_prompt");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode MisalignmentPolicyViolation { get; } = new("misalignment_policy_violation");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode RateLimitExceeded { get; } = new("rate_limit_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode ServerError { get; } = new("server_error");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode UnsupportedImageMediaType { get; } = new("unsupported_image_media_type");

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode VectorStoreTimeout { get; } = new("vector_store_timeout");
        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesErrorFieldCode FromValue(string value)
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
                _ => new OpenResponsesErrorFieldCode(value),
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
        public bool Equals(OpenResponsesErrorFieldCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenResponsesErrorFieldCode other && Equals(other);
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
        public static bool operator ==(OpenResponsesErrorFieldCode left, OpenResponsesErrorFieldCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OpenResponsesErrorFieldCode left, OpenResponsesErrorFieldCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenResponsesErrorFieldCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenResponsesErrorFieldCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenResponsesErrorFieldCode? ToEnum(string value)
        {
            return OpenResponsesErrorFieldCode.FromValue(value);
        }
    }
}