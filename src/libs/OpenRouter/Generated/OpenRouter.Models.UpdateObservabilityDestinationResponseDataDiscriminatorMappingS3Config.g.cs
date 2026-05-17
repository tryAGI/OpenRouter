
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationResponseDataDiscriminatorMappingS3Config
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// Only for S3-compatible services like Cloudflare R2 (https://account-id.r2.cloudflarestorage.com) or MinIO. Leave blank for standard AWS S3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Template for S3 object path. The filename ({traceId}-{timestamp}.json) is automatically appended. Available variables: {prefix}, {date}, {year}, {month}, {day}, {apiKeyName}<br/>
        /// Default Value: {prefix}/{date}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathTemplate")]
        public string? PathTemplate { get; set; }

        /// <summary>
        /// Default Value: openrouter-traces
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretAccessKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretAccessKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionToken")]
        public string? SessionToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingS3Config" /> class.
        /// </summary>
        /// <param name="accessKeyId"></param>
        /// <param name="bucketName"></param>
        /// <param name="secretAccessKey"></param>
        /// <param name="endpoint">
        /// Only for S3-compatible services like Cloudflare R2 (https://account-id.r2.cloudflarestorage.com) or MinIO. Leave blank for standard AWS S3.
        /// </param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
        /// <param name="pathTemplate">
        /// Template for S3 object path. The filename ({traceId}-{timestamp}.json) is automatically appended. Available variables: {prefix}, {date}, {year}, {month}, {day}, {apiKeyName}<br/>
        /// Default Value: {prefix}/{date}
        /// </param>
        /// <param name="prefix">
        /// Default Value: openrouter-traces
        /// </param>
        /// <param name="region"></param>
        /// <param name="sessionToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingS3Config(
            string accessKeyId,
            string bucketName,
            string secretAccessKey,
            string? endpoint,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? pathTemplate,
            string? prefix,
            string? region,
            string? sessionToken)
        {
            this.AccessKeyId = accessKeyId ?? throw new global::System.ArgumentNullException(nameof(accessKeyId));
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.Endpoint = endpoint;
            this.Headers = headers;
            this.PathTemplate = pathTemplate;
            this.Prefix = prefix;
            this.Region = region;
            this.SecretAccessKey = secretAccessKey ?? throw new global::System.ArgumentNullException(nameof(secretAccessKey));
            this.SessionToken = sessionToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingS3Config" /> class.
        /// </summary>
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingS3Config()
        {
        }

    }
}