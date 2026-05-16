
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservabilitySnowflakeDestinationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Account { get; set; }

        /// <summary>
        /// Default Value: SNOWFLAKE_LEARNING_DB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database")]
        public string? Database { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Default Value: PUBLIC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public string? Schema { get; set; }

        /// <summary>
        /// Default Value: OPENROUTER_TRACES
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public string? Table { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Default Value: COMPUTE_WH
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warehouse")]
        public string? Warehouse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilitySnowflakeDestinationConfig" /> class.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="token"></param>
        /// <param name="database">
        /// Default Value: SNOWFLAKE_LEARNING_DB
        /// </param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
        /// <param name="schema">
        /// Default Value: PUBLIC
        /// </param>
        /// <param name="table">
        /// Default Value: OPENROUTER_TRACES
        /// </param>
        /// <param name="warehouse">
        /// Default Value: COMPUTE_WH
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservabilitySnowflakeDestinationConfig(
            string account,
            string token,
            string? database,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? schema,
            string? table,
            string? warehouse)
        {
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.Database = database;
            this.Headers = headers;
            this.Schema = schema;
            this.Table = table;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Warehouse = warehouse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilitySnowflakeDestinationConfig" /> class.
        /// </summary>
        public ObservabilitySnowflakeDestinationConfig()
        {
        }

    }
}