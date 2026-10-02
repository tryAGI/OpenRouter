
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Why the check failed.<br/>
    /// Example: no_byok_key
    /// </summary>
    public readonly partial struct PrivateEndpointCheckReason : global::System.IEquatable<PrivateEndpointCheckReason>
    {
        /// <summary>
        ///
        /// </summary>
        public PrivateEndpointCheckReason(string value)
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
        public static PrivateEndpointCheckReason DatabaseError { get; } = new("database_error");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason EndpointLimitReached { get; } = new("endpoint_limit_reached");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason EndpointNotFound { get; } = new("endpoint_not_found");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason InvalidBaseUrl { get; } = new("invalid_base_url");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason InvalidResponse { get; } = new("invalid_response");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason InvalidStream { get; } = new("invalid_stream");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason KeyDecryptionFailed { get; } = new("key_decryption_failed");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason MissingUsage { get; } = new("missing_usage");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason ModelMismatch { get; } = new("model_mismatch");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason ModelNotFound { get; } = new("model_not_found");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason NoByokKey { get; } = new("no_byok_key");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason NotValidated { get; } = new("not_validated");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason ProviderNotFound { get; } = new("provider_not_found");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason UpstreamError { get; } = new("upstream_error");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason ValidationStale { get; } = new("validation_stale");

        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason WorkspaceNotFound { get; } = new("workspace_not_found");
        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointCheckReason FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "database_error" => DatabaseError,
                "endpoint_limit_reached" => EndpointLimitReached,
                "endpoint_not_found" => EndpointNotFound,
                "invalid_base_url" => InvalidBaseUrl,
                "invalid_response" => InvalidResponse,
                "invalid_stream" => InvalidStream,
                "key_decryption_failed" => KeyDecryptionFailed,
                "missing_usage" => MissingUsage,
                "model_mismatch" => ModelMismatch,
                "model_not_found" => ModelNotFound,
                "no_byok_key" => NoByokKey,
                "not_validated" => NotValidated,
                "provider_not_found" => ProviderNotFound,
                "upstream_error" => UpstreamError,
                "validation_stale" => ValidationStale,
                "workspace_not_found" => WorkspaceNotFound,
                _ => new PrivateEndpointCheckReason(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "database_error" => true,
            "endpoint_limit_reached" => true,
            "endpoint_not_found" => true,
            "invalid_base_url" => true,
            "invalid_response" => true,
            "invalid_stream" => true,
            "key_decryption_failed" => true,
            "missing_usage" => true,
            "model_mismatch" => true,
            "model_not_found" => true,
            "no_byok_key" => true,
            "not_validated" => true,
            "provider_not_found" => true,
            "upstream_error" => true,
            "validation_stale" => true,
            "workspace_not_found" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(PrivateEndpointCheckReason other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrivateEndpointCheckReason other && Equals(other);
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
        public static bool operator ==(PrivateEndpointCheckReason left, PrivateEndpointCheckReason right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PrivateEndpointCheckReason left, PrivateEndpointCheckReason right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateEndpointCheckReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateEndpointCheckReason value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateEndpointCheckReason? ToEnum(string value)
        {
            return PrivateEndpointCheckReason.FromValue(value);
        }
    }
}