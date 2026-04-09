
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseHealingPlugin
    {
        /// <summary>
        /// Set to false to disable the response-healing plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ResponseHealingPluginIdJsonConverter))]
        public global::OpenRouter.ResponseHealingPluginId Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHealingPlugin" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Set to false to disable the response-healing plugin for this request. Defaults to true.
        /// </param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseHealingPlugin(
            bool? enabled,
            global::OpenRouter.ResponseHealingPluginId id)
        {
            this.Enabled = enabled;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHealingPlugin" /> class.
        /// </summary>
        public ResponseHealingPlugin()
        {
        }
    }
}