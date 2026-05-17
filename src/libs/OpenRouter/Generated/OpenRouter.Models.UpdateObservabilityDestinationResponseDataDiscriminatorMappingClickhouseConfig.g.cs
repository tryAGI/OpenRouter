
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationResponseDataDiscriminatorMappingClickhouseConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Database { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// Default Value: OPENROUTER_TRACES
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public string? Table { get; set; }

        /// <summary>
        /// If you have not set a specific username in ClickHouse, simply type in 'default' below.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingClickhouseConfig" /> class.
        /// </summary>
        /// <param name="database"></param>
        /// <param name="host"></param>
        /// <param name="password"></param>
        /// <param name="username">
        /// If you have not set a specific username in ClickHouse, simply type in 'default' below.
        /// </param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
        /// <param name="table">
        /// Default Value: OPENROUTER_TRACES
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingClickhouseConfig(
            string database,
            string host,
            string password,
            string username,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? table)
        {
            this.Database = database ?? throw new global::System.ArgumentNullException(nameof(database));
            this.Headers = headers;
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
            this.Table = table;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingClickhouseConfig" /> class.
        /// </summary>
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingClickhouseConfig()
        {
        }

    }
}