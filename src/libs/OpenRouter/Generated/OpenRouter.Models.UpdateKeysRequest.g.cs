
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"disabled":false,"include_byok_in_limit":true,"limit":75,"limit_reset":"daily","name":"Updated API Key Name"}
    /// </summary>
    public sealed partial class UpdateKeysRequest
    {
        /// <summary>
        /// Whether to disable the API key<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Whether to include BYOK usage in the limit<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_limit")]
        public bool? IncludeByokInLimit { get; set; }

        /// <summary>
        /// New spending limit for the API key in USD<br/>
        /// Example: 75
        /// </summary>
        /// <example>75</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.<br/>
        /// Example: daily
        /// </summary>
        /// <example>daily</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_reset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UpdateKeysRequestLimitResetJsonConverter))]
        public global::OpenRouter.UpdateKeysRequestLimitReset? LimitReset { get; set; }

        /// <summary>
        /// New name for the API key<br/>
        /// Example: Updated API Key Name
        /// </summary>
        /// <example>Updated API Key Name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKeysRequest" /> class.
        /// </summary>
        /// <param name="disabled">
        /// Whether to disable the API key<br/>
        /// Example: false
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit<br/>
        /// Example: true
        /// </param>
        /// <param name="limit">
        /// New spending limit for the API key in USD<br/>
        /// Example: 75
        /// </param>
        /// <param name="limitReset">
        /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.<br/>
        /// Example: daily
        /// </param>
        /// <param name="name">
        /// New name for the API key<br/>
        /// Example: Updated API Key Name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateKeysRequest(
            bool? disabled,
            bool? includeByokInLimit,
            double? limit,
            global::OpenRouter.UpdateKeysRequestLimitReset? limitReset,
            string? name)
        {
            this.Disabled = disabled;
            this.IncludeByokInLimit = includeByokInLimit;
            this.Limit = limit;
            this.LimitReset = limitReset;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKeysRequest" /> class.
        /// </summary>
        public UpdateKeysRequest()
        {
        }

    }
}