
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateKeysRequest
    {
        /// <summary>
        /// Whether to disable the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Whether to include BYOK usage in the limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_limit")]
        public bool? IncludeByokInLimit { get; set; }

        /// <summary>
        /// New spending limit for the API key in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_reset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?, object>? LimitReset { get; set; }

        /// <summary>
        /// New name for the API key
        /// </summary>
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
        /// Whether to disable the API key
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit
        /// </param>
        /// <param name="limit">
        /// New spending limit for the API key in USD
        /// </param>
        /// <param name="limitReset">
        /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </param>
        /// <param name="name">
        /// New name for the API key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateKeysRequest(
            bool? disabled,
            bool? includeByokInLimit,
            double? limit,
            global::OpenRouter.OneOf<global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?, object>? limitReset,
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